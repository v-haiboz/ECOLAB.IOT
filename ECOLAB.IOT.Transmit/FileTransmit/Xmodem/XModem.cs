namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using System;
    using System.Net.Sockets;
    using System.Runtime.Intrinsics.Arm;
    using System.Text;

    public partial class XModem : IFileTransmit
    {
        private bool crc = false;
        public void Send()
        {
            if (SendResultEvent != null)
            {
                SendResultEvent(true, null);
            }
            FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read);
            BinaryReader b_reader = new BinaryReader(fileStream);
            long length = fileStream.Length;
            int err = 0;
            string Read_line;
            Sender_Packet_Number = 1;
            if (!serialPort.IsOpen)
            {
                return;
            }
            serialPort.ReadTimeout = 15000;
            try
            {
                this.wait_c();
                Sender_Data = b_reader.ReadBytes(128);
                var maxRetry = 6;
                err = Send_Packet(Sender_Data, Sender_Packet_Number, 128);
                var retry = 1;
                while (retry<= maxRetry)
                {
                    if (err == 1)
                    {
                        Sender_Data = b_reader.ReadBytes(128);
                        var data_Length = Sender_Data.Length;
                        if (Sender_Data.Length == 0)
                        {
                            serialPort.Write(Sender_EOT, 0, 1);
                            Console.WriteLine("End To Transmit,Send Successful.");
                            break;
                        }
                        else if (Sender_Data.Length != 128)
                        {
                            byte[] full_stream = new byte[128];
                            byte[] zero_ary = new byte[128 - Sender_Data.Length];
                            Array.Clear(zero_ary, 0, zero_ary.Length);
                           

                            Array.Copy(Sender_Data, 0, full_stream, 0, Sender_Data.Length);
                            Array.Copy(zero_ary, 0, full_stream, Sender_Data.Length, zero_ary.Length);

                            Sender_Data = full_stream;
                        }

                        Sender_Packet_Number++;
                        err = Send_Packet(Sender_Data, Sender_Packet_Number, 128);
                        Console.WriteLine($"Packet_Number:{Sender_Packet_Number} ");
                        var percentage = ((double)((Sender_Packet_Number-1)*128+ data_Length) / length) * 100;
                        int tmp2 = (int)Math.Round(Convert.ToDouble(percentage));
                        Console.WriteLine($"Send percentage:{tmp2}%,->Data Length:{data_Length}");
                        retry = 1;
                    }
                    else
                    {
                        if (retry > 1)
                        {
                            Console.WriteLine($"{retry} Resend  Packet_Number:{Sender_Packet_Number}");
                        }
                        else {
                            Console.WriteLine($"Packet_Number:{Sender_Packet_Number}");
                        }
                        
                        err = Send_Packet(Sender_Data, Sender_Packet_Number, err);
                        var percentage = ((double)((Sender_Packet_Number - 1) * 128 + Sender_Data.Length) / length) * 100;
                        int tmp2 = (int)Math.Round(Convert.ToDouble(percentage));
                        Console.WriteLine($"Send percentage:{tmp2}%,->Data Length:{Sender_Data.Length}");
                        if (retry == maxRetry)
                        {
                            Console.WriteLine($"End To Transmit, Send Failed, Packet_Number:{Sender_Packet_Number}");
                        }
                        retry++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Transmit does not answering.{ex}");
                throw new Exception("Transmit does not answering");
            }
            finally
            {
                fileStream.Close();
                fileStream.Dispose();
                if (SendResultEvent != null)
                {
                    SendResultEvent(false, null);
                }
            }
        }
        private int Send_Packet(byte[] data, byte SPN, int Length)
        {
            byte[] send_Data = null;

            if (!crc)
            {
                 send_Data = GeneratePackage(data, SPN, Length);
            }
            else {
                send_Data = GeneratePackageByCRC(data, SPN, Length);
            }
         
            serialPort.Write(send_Data, 0, send_Data.Length);

            return Wait_ACK_NAK(Length);

        }

        private byte[] GeneratePackage(byte[] data,byte SPN, int Length)
        {
            var temp = new byte[3 + Length + 1];
            if (Length == 128)
            {
                temp[0] =   (byte)XModemMessageType.SOH;
            }
            else if (Length == 1024)
            {
                temp[0] =  (byte)XModemMessageType.SOX;
            }

            temp[1] = SPN;
            temp[2] = (byte)(~SPN);
            Array.Copy(data, 0, temp, 3, Length);

            byte ccks = 0;
            for (var i = 3; i < 128 + 3; ++i)
            {
                ccks += temp[i];
            }

            temp[128 + 3] = ccks;
            Console.WriteLine($"Check bit:{ccks}");
            return temp;
        }
        private byte[] GeneratePackageByCRC(byte[] data, byte SPN, int Length)
        {
            var temp = new byte[3 + Length + 2];
            if (Length == 128)
            {
                temp[0] = (byte)XModemMessageType.SOH;
            }
            else if (Length == 1024)
            {
                temp[0] = (byte)XModemMessageType.SOX;
            }

            temp[1] = SPN;
            temp[2] = (byte)(~SPN);
            Array.Copy(data, 0, temp, 3, Length);

            Sender_Crc_us = crc16.CRC16_ccitt(data, 0, Length);
            Sender_Crc[0] = (byte)((Sender_Crc_us >> 8) & 0xFF);
            Sender_Crc[1] = (byte)(Sender_Crc_us & 0xFF);
            temp[3 + Length] = Sender_Crc[0];
            temp[3 + Length + 1] = Sender_Crc[1];
            Console.WriteLine($"CRC Check bit:{Sender_Crc[0]}-{Sender_Crc[1]}");
            return temp;
        }
        private void wait_c()
        {
            char readchar;
            while (true)
            {
                    readchar = (char)serialPort.ReadChar();
                    Console.Write(readchar.ToString());
                    if (readchar == (byte)XModemMessageType.NAK)
                    {
                        crc = false;
                        Console.WriteLine();
                        Console.WriteLine("Start To Transmit");
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
                    SPort_read = serialPort.ReadChar();
                    if (SPort_read == (byte)XModemMessageType.NAK)
                    {
                        //OutPutEvent(this, new TrackerReceiveData("NAK"));
                        Console.WriteLine("NAK");
                        return Length;
                    }
                    else if (SPort_read == (byte)XModemMessageType.ACK)
                    {
                        //OutPutEvent(this, new TrackerReceiveData("ACK"));
                        Console.WriteLine("ACK");
                        return 1;
                    }
                    else
                    {
                        //OutPutEvent(this, new TrackerReceiveData(SPort_read.ToString()));
                        Console.WriteLine(SPort_read.ToString());
                    }
                }
            
        }
    }
}
