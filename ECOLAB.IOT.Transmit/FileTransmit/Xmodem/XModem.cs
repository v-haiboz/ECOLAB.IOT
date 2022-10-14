namespace ECOLAB.IOT.Transmit.FileTransmit.Xmodem
{
    using System;

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
                Sender_Data = b_reader.ReadBytes(1024);
                err = Send_Packet(Sender_Data, Sender_Packet_Number, 1024);
                while (true)
                {
                    if (err == 1)
                    {
                        Sender_Data = b_reader.ReadBytes(1024);

                        if (Sender_Data.Length == 0)
                        {
                            SPort.Write(Sender_EOT, 0, 1);
                            while (true)
                            {
                                Read_line = SPort.ReadLine();
                                Console.Write(Read_line);
                            }

                            //break;
                        }
                        else if (Sender_Data.Length != 1024)
                        {
                            byte[] full_stream = new byte[1024];
                            byte[] zero_ary = new byte[1024 - Sender_Data.Length];
                            Array.Clear(zero_ary, 0, zero_ary.Length);
                            OutPutEvent?.Invoke(this, new TrackerReceiveData(Sender_Data.Length.ToString()));
                            Console.WriteLine(Sender_Data.Length);

                            Array.Copy(Sender_Data, 0, full_stream, 0, Sender_Data.Length);
                            Array.Copy(zero_ary, 0, full_stream, Sender_Data.Length, zero_ary.Length);

                            Sender_Data = full_stream;
                        }

                        Sender_Packet_Number++;
                        err = Send_Packet(Sender_Data, Sender_Packet_Number, 1024);
                    }
                    else
                    {
                        err = Send_Packet(Sender_Data, Sender_Packet_Number, err);
                    }
                }
            }
            catch (Exception ex)
            {
                if (OutPutEvent != null)
                {
                    OutPutEvent(this, new TrackerReceiveData("Transmit does not answering"));
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

            //Sender_Packet[2] = BitConverter.GetBytes(255 - SPN)[0];
            Sender_Packet[2] = (byte)(~SPN);
            OutPutEvent?.Invoke(this, new TrackerReceiveData(BitConverter.ToString(Sender_Packet)));
            Console.WriteLine(BitConverter.ToString(Sender_Packet));
            SPort.Write(Sender_Packet, 0, 3);

            OutPutEvent?.Invoke(this, new TrackerReceiveData(BitConverter.ToString(data)));
            Console.WriteLine(BitConverter.ToString(data));
            SPort.Write(data, 0, Length);

            //Sender_Crc = crc16.ComputeCrc(data);
            //Sender_Crc = Crc_o.calcrc(data);
            Sender_Crc_us = Crc_o.ComputeChecksum(data);
            Sender_Crc[0] = (byte)((Sender_Crc_us >> 8) & 0xFF);
            Sender_Crc[1] = (byte)(Sender_Crc_us & 0xFF);

            OutPutEvent?.Invoke(this, new TrackerReceiveData(BitConverter.ToString(Sender_Crc)));
            Console.WriteLine(BitConverter.ToString(Sender_Crc));
            SPort.Write(Sender_Crc, 0, 2);

            return Wait_ACK_NAK(Length);
        }
        private void wait_c()
        {
            char readchar;
            while (true)
            {
                readchar = (char)SPort.ReadChar();
                OutPutEvent?.Invoke(this, new TrackerReceiveData(readchar.ToString()));
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

            while (true)
            {
                Console.WriteLine("Wait_ACK_NAK");
                SPort_read = SPort.ReadChar();//Console.Read();

                if (SPort_read == (byte)XModemMessageType.NAK) 		//Constants.NAK
                {
                    OutPutEvent?.Invoke(this, new TrackerReceiveData("NAK"));
                    Console.WriteLine("NAK");
                    return Length;
                }
                else if (SPort_read == (byte)XModemMessageType.ACK) 	//Constants.ACK
                {
                    OutPutEvent?.Invoke(this, new TrackerReceiveData("ACK"));
                    Console.WriteLine("ACK");
                    return 1;
                }
                else
                {
                    OutPutEvent?.Invoke(this, new TrackerReceiveData(SPort_read.ToString()));
                    Console.WriteLine(SPort_read);
                }
            }
        }
    }
}
