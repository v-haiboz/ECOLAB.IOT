namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using System;
    using System.Net.Sockets;
    using System.Runtime.Intrinsics.Arm;
    using System.Text;

    public partial class XModem : IFileTransmit
    {

        public void Send()
        {
            if (SendResultEvent != null)
            {
                SendResultEvent(true, null);
            }
            FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read);
            BinaryReader b_reader = new BinaryReader(fileStream);
            int err = 0;
            string Read_line;
            Sender_Packet_Number = 1;
            if (!serialPort.IsOpen)
            {
                return;
            }
            serialPort.ReadTimeout = 2000;
            try
            {
                this.wait_c();
                Sender_Data = b_reader.ReadBytes(128);
                var maxRetry = 13;
                err = Send_Packet(Sender_Data, Sender_Packet_Number, 128);
                var retry = 0;
                while (retry< maxRetry)
                {
                    if (err == 1)
                    {
                        Sender_Data = b_reader.ReadBytes(128);

                        if (Sender_Data.Length == 0)
                        {
                            serialPort.Write(Sender_EOT, 0, 1);
                            while (true)
                            {
                                Read_line = serialPort.ReadLine();
                                Console.Write(Read_line);
                            }

                            //break;
                        }
                        else if (Sender_Data.Length != 128)
                        {
                            byte[] full_stream = new byte[128];
                            byte[] zero_ary = new byte[128 - Sender_Data.Length];
                            Array.Clear(zero_ary, 0, zero_ary.Length);
                            OutPutEvent?.Invoke(this, new TrackerReceiveData(Sender_Data.Length.ToString()));
                            Console.WriteLine(Sender_Data.Length);

                            Array.Copy(Sender_Data, 0, full_stream, 0, Sender_Data.Length);
                            Array.Copy(zero_ary, 0, full_stream, Sender_Data.Length, zero_ary.Length);

                            Sender_Data = full_stream;
                        }

                        Sender_Packet_Number++;
                        err = Send_Packet(Sender_Data, Sender_Packet_Number, 128);
                        retry = 0;
                    }
                    else
                    {
                        err = Send_Packet(Sender_Data, Sender_Packet_Number, err);
                        retry++;
                    }
                }
            }
            catch (Exception ex)
            {
                if (OutPutEvent != null)
                {
                    OutPutEvent(this, new TrackerReceiveData($"Transmit does not answering.{ex}"));
                }
                throw new Exception("Transmit does not answering");
            }
            finally
            {
                if (SendResultEvent != null)
                {
                    SendResultEvent(false, null);
                }
            }

        }
        private int Send_Packet(byte[] data, byte SPN, int Length)
        {

            if (Length == 128)
            {
                Sender_Packet[0] = (byte)XModemMessageType.SOH;
            }
            else if (Length == 1024)
            {
                Sender_Packet[0] = (byte)XModemMessageType.SOX;
            }
            Sender_Packet[1] = SPN;


            //var crc16 = new Crc16Ccitt();
            //Sender_Crc_us = crc16.ComputeChecksum(data);
            var temp = new byte[3 + Length + 1];
            temp[0] = (byte)XModemMessageType.SOH;
            temp[1] = SPN;
            temp[2] = (byte)(~SPN);
            Array.Copy(data, 0, temp, 3, Length);
            //temp[3 + Length] = (byte)(Sender_Crc_us >> 8);
            //temp[3 + Length + 1] = (byte)(Sender_Crc_us & 0xFF);

            //Sender_Packet[2] = BitConverter.GetBytes(255 - SPN)[0];
            Sender_Packet[2] = (byte)(~SPN);
            ////OutPutEvent(this, new TrackerReceiveData(BitConverter.ToString(Sender_Packet)));
            //Console.WriteLine(BitConverter.ToString(Sender_Packet));
            //serialPort.Write(Sender_Packet, 0, 3);

            //OutPutEvent(this, new TrackerReceiveData(BitConverter.ToString(data)));
            Console.WriteLine(BitConverter.ToString(data));
            //serialPort.Write(data, 0, Length);

            var crc16 = new Crc16Ccitt();
            Sender_Crc_us = crc16.ComputeChecksum(data);
            ////Sender_Crc_us = Crc16.CRC16_ccitt(data, 0, Length);
            Sender_Crc[0] = (byte)((Sender_Crc_us >> 8) & 0xFF);
            Sender_Crc[1] = (byte)(Sender_Crc_us & 0xFF);

            //Sender_Crc_us = crc16.CRC16_ccitt(data, 0, Length);
            //Sender_Crc[0] = (byte)((Sender_Crc_us >> 8) & 0xFF);
            //Sender_Crc[1] = (byte)(Sender_Crc_us & 0xFF);

            //byte ccks = 0;
            //for (i = 3; i < bufsz + 3; ++i)
            //{
            //    ccks += xbuff[i];
            //}
            //temp[bufsz + 3] = ccks;

            temp[3 + Length] = Sender_Crc[0];
            temp[3 + Length + 1] = Sender_Crc[1];
            OutPutEvent(this, new TrackerReceiveData(BitConverter.ToString(Sender_Crc)));
            Console.WriteLine(BitConverter.ToString(Sender_Crc));
            serialPort.Write(temp, 0, temp.Length);

            return Wait_ACK_NAK(Length);

        }
        private void wait_c()
        {
            char readchar;
            while (true)
            {
                readchar = (char)serialPort.ReadChar();
                OutPutEvent(this, new TrackerReceiveData(readchar.ToString()));
                Console.WriteLine(readchar);
                if (readchar == 'C')
                {
                    break;
                }
            }
        }
        private int Wait_ACK_NAK(int Length)
        {
            int SPort_read;
            Thread.Sleep(3000);
            while (true)
            {
                Console.WriteLine("Wait_ACK_NAK");
                SPort_read = serialPort.ReadChar();//Console.Read();
                if (SPort_read == 67) 	//Constants.ACK
                {
                    OutPutEvent(this, new TrackerReceiveData("ACK"));
                    Console.WriteLine("ACK");
                    return 1;
                }
                else if (SPort_read == (byte)XModemMessageType.NAK) 		//Constants.NAK
                {
                    OutPutEvent(this, new TrackerReceiveData("NAK"));
                    Console.WriteLine("NAK");
                    return Length;
                }
                else if (SPort_read == (byte)XModemMessageType.ACK) 	//Constants.ACK
                {
                    OutPutEvent(this, new TrackerReceiveData("ACK"));
                    Console.WriteLine("ACK");
                    return 1;
                }
                else
                {
                    OutPutEvent(this, new TrackerReceiveData(SPort_read.ToString()));
                    Console.WriteLine(SPort_read);
                }
            }
        }
    }
}
