﻿namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using ECOLAB.IOT.Service;
    using System;
    using System.IO.Ports;
    using System.Text;

    public partial class XModem : IFileTransmit
    {
        private static bool DeviceLogContinuity = CallerContext.ECOLABIOTLogSettingService.GetLogSetting().DeviceLogContinuity;

        public void Send()
        {
            serialPort.DiscardOutBuffer();
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();
            serialPort.DiscardInBuffer();
            if (SendResultEvent != null)
            {
                SendResultEvent(KeyValuePair.Create(true,true), null);
            }
            FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read);
            BinaryReader b_reader = new BinaryReader(fileStream);
            long length = fileStream.Length;
            if (length >= 1024 * 1024)
            {
                MessageBoxEvent(null, new TrackerMessageBox("File size cannot exceed 1M", "ToolTip"));
                if (SendResultEvent != null)
                {
                    SendResultEvent(false, null);
                }
                return;
            }
            int err = 0;
            string Read_line;
            Sender_Packet_Number = 1;
            Sender_Packet_Number_Total++;
            if (!serialPort.IsOpen)
            {
                return;
            }
            serialPort.ReadTimeout = 10000;
            try
            {
                this.wait_c();
                Sender_Data = b_reader.ReadBytes(128);
                var data_Length = Sender_Data.Length;
                var maxRetry = 1;
                if (Sender_Data.Length != 128)
                {
                    ConverTo128();
                }
                err = Send_Packet(Sender_Data, Sender_Packet_Number, 128, realLength: data_Length, totalLength: length);
                var retry = 1;
                while (retry <= maxRetry)
                {
                    if (Sender_Packet_Number>=255)
                    {
                        DeviceLog($"End To Transmit, Send Failed, The file is too large, Packet_Number:{Sender_Packet_Number}");
                        break;
                    }
                    if (err == 1)
                    {
                        Sender_Data = b_reader.ReadBytes(128);
                        data_Length = Sender_Data.Length;
                        if (Sender_Data.Length == 0)
                        {
                            serialPort.Write(Sender_EOT, 0, 1);
                            MessageBoxEvent(null, new TrackerMessageBox(OutTransforer("message_file_successful"), OutTransforer("message_file_tooltip"), messageBoxIcon: ReceviedMessageBoxIcon.Information));
                            DeviceLog($"{OutTransforer("message_file_successful")}\r");
                            break;
                        }
                        else if (Sender_Data.Length != 128)
                        {
                            ConverTo128();
                        }

                        Sender_Packet_Number++;
                        Sender_Packet_Number_Total++;
                        err = Send_Packet(Sender_Data, Sender_Packet_Number, 128, realLength: data_Length, totalLength: length);
                        retry = 1;
                    }
                    else
                    {
                        if (retry > 1)
                        {
                            DeviceLog($"{retry} Resend  Packet_Number:{Sender_Packet_Number}");
                            err = Send_Packet(Sender_Data, Sender_Packet_Number, err, realLength: data_Length, totalLength: length);
                        }
                        else
                        {
                            DeviceLog($"Packet_Number:{Sender_Packet_Number}");
                        }

                        if (retry == maxRetry)
                        {
                            Abort();
                            Thread.Sleep(3000);
                            MessageBoxEvent(null, new TrackerMessageBox($"{OutTransforer("message_file_failed")}{Sender_Packet_Number}", OutTransforer("message_file_tooltip"), messageBoxIcon: ReceviedMessageBoxIcon.Error));
                            DeviceLog($"{OutTransforer("message_file_failed")}{Sender_Packet_Number}\r");
                            break;
                        }
                        retry++;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The operation has timed out."))
                {
                    MessageBoxEvent(null, new TrackerMessageBox($"{OutTransforer("message_file_exception2")}", OutTransforer("message_file_tooltip"), messageBoxIcon: ReceviedMessageBoxIcon.Error));
                    DeviceLog($"Transmit does not answering, The operation has timed out.\r");
                }
                else
                {
                    MessageBoxEvent(null, new TrackerMessageBox($"{OutTransforer("message_file_exception1")},{ex.Message}", OutTransforer("message_file_tooltip"), messageBoxIcon: ReceviedMessageBoxIcon.Error));
                    DeviceLog($"Transmit does not answering, {ex.Message}\r");
                }
                
                throw new Exception("Transmit does not answering");
            }
            finally
            {
                fileStream.Close();
                fileStream.Dispose();
                if (SendResultEvent != null)
                {
                    SendResultEvent(KeyValuePair.Create(false, true), null);
                }
                serialPort.ReadTimeout = 10000;
            }
        }
        private void ShowPercentage(int data_length, double total_length)
        {
            double percentage = 100;
            
            if (data_length == 128)
            {
                percentage = ((double)(Sender_Packet_Number_Total * 128) / total_length) * 100;
            }
#if DEBUG
            DeviceLog($"{Sender_Packet_Number_Total} -{ total_length}");
#endif
            var tmp=Math.Floor(percentage * 100) / 100.00;
            DeviceLog($"Send percentage:{tmp}%,->Data Length:{data_length}");
        }
        private void ConverTo128()
        {
            byte[] full_stream = new byte[128];
            byte[] zero_ary = new byte[128 - Sender_Data.Length];
            Array.Clear(zero_ary, 0, zero_ary.Length);

            for (var i = 0; i < 128 - Sender_Data.Length;i++)
            {
                zero_ary[i] = (byte)XModemMessageType.CTRLZ;
            }

            Array.Copy(Sender_Data, 0, full_stream, 0, Sender_Data.Length);
            Array.Copy(zero_ary, 0, full_stream, Sender_Data.Length, zero_ary.Length);

            Sender_Data = full_stream;
        }
        private int Send_Packet(byte[] data, byte SPN, int length, int realLength, long totalLength)
        {
            byte[] send_Data = null;

            if (!isCRC)
            {
                send_Data = GeneratePackage(data, SPN, length);
            }
            else
            {
                send_Data = GeneratePackageByCRC(data, SPN, length);
            }

            serialPort.Write(send_Data, 0, send_Data.Length);
            ShowPercentage(realLength, totalLength);
            return Wait_ACK_NAK(length);

        }

        private byte[] GeneratePackage(byte[] data, byte SPN, int Length)
        {
            var temp = new byte[3 + Length + 1];
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

            byte ccks = 0;
            for (var i = 3; i < 128 + 3; ++i)
            {
                ccks += temp[i];
            }

            temp[128 + 3] = ccks;
#if DEBUG
            DeviceLog($"Check bit:{ccks}");
#endif
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
#if DEBUG
            DeviceLog($"CRC Check bit:{Sender_Crc[0]}-{Sender_Crc[1]}");
#endif
            return temp;
        }
        private void wait_c()
        {
            DeviceLog($"{OutTransforer("message_file_progress")}\r", false);
            char readchar;
            while (true)
            {
                readchar=(char)serialPort.ReadChar();
                DeviceLog(readchar.ToString(), false);
                if (!isCRC)
                {
                    if (readchar == (byte)XModemMessageType.NAK)
                    {
                        DeviceLog("Start To Transmit",true);
                        break;
                    }
                }
                else
                {
                    if (readchar == 'C')
                    {
                        DeviceLog("Start To Transmit", true);
                        break;
                    }
                }
            }
        }

        private int Wait_ACK_NAK(int Length)
        {
            int SPort_read;
            while (true)
            {
#if DEBUG
                DeviceLog("Wait_ACK_NAK");
#endif
                SPort_read = (char)serialPort.ReadChar();
                if (SPort_read == (byte)XModemMessageType.NAK)
                {
#if DEBUG
                    DeviceLog("NAK");
#endif
                    return Length;
                }
                else if (SPort_read == (byte)XModemMessageType.ACK)
                {
#if DEBUG
                    DeviceLog("ACK");
#endif
                    return 1;
                }
                else
                {
#if DEBUG
                    DeviceLog(SPort_read.ToString());
#endif
                }
            }

        }

        private void DeviceLog(string str, bool isWriteEmptyLine=true)
        {
            if (OutPutEvent != null)
            {
                OutPutEvent(this, new TrackerReceiveData(str,isWriteLine: isWriteEmptyLine));
            }
        }

        private void Abort()
        {
            SendCAN();
        }

        private void SendCAN()
        {
            byte[] bytes = new byte[1] { (byte)XModemMessageType.CAN };
            serialPort.Write(bytes, 0, bytes.Length);
            serialPort.Write(bytes, 0, bytes.Length);
            serialPort.Write(bytes, 0, bytes.Length);
        }
    }
}
