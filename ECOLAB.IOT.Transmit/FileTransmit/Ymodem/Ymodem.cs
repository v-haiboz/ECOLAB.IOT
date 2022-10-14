namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using System;
    using System.Diagnostics;
    using System.IO.Ports;
    using ECOLAB.IOT.Transmit;

    public partial class YModem : IFileTransmit
    {
       
        public void Send()
        {
            if(SendResultEvent!=null)
            {
                SendResultEvent(true, null);
            }
            
            FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read);
            if (!serialPort.IsOpen)
            {
                return;
            }
            serialPort.ReadTimeout = 2000;
            try
            {
                if (serialPort.ReadByte() !=(byte)YModemMessageType.KEY_C)
                {
                    if (OutPutEvent != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData("Can't begin the transfer."));
                    }
                    Debug.WriteLine("Can't begin the transfer.");
                    serialPort.Close();
                    SendResultEvent.Invoke(false, new EventArgs());
                    return;
                }
                else
                {
                    Debug.WriteLine(" begin the transfer.");
                    if (OutPutEvent != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData(" begin the transfer."));
                    }
                }

                SendInitialPacket(YModemMessageType.STX, packetNumber, invertedPacketNumber, data, dataSize, path, fileStream, CRC, crcSize);
                // Thread.Sleep(5000);

                byte temp = (byte)serialPort.ReadByte();
                Debug.WriteLine(temp);
                if (temp !=(byte)YModemMessageType.ACK)//(serialPort.ReadByte() != ACK)
                {
                    if (OutPutEvent != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData("Can't send the initial packet."));
                    }
                    Debug.WriteLine("Can't send the initial packet.");
                    SendResultEvent.Invoke(false, new EventArgs());
                    return;// false;
                }

                if (serialPort.ReadByte() !=(byte)YModemMessageType.KEY_C)
                {
                    SendResultEvent.Invoke(false, new EventArgs());
                    return;// false;
                }

                /* send packets with a cycle until we send the last byte */
                int fileReadCount;
                do
                {
                    /* if this is the last packet fill the remaining bytes with 0 */
                    fileReadCount = fileStream.Read(data, 0, dataSize);
                    if (fileReadCount == 0) break;
                    if (fileReadCount != dataSize)
                        for (int i = fileReadCount; i < dataSize; i++)
                            data[i] = 0;

                    /* calculate packetNumber */
                    packetNumber++;
                    if (packetNumber > 255)
                        packetNumber -= 256;
                    Console.WriteLine(packetNumber);

                    /* calculate invertedPacketNumber */
                    invertedPacketNumber = 255 - packetNumber;

                    /* calculate CRC */
                    Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
                    CRC = crc16Ccitt.ComputeChecksumBytes(data);

                    /* send the packet */
                    SendPacket(YModemMessageType.STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize);
                    int progress = (int)(((float)dataSize * packetNumber) / fileStream.Length * 100);
                    Debug.WriteLine("progress:  " + progress);
                    if (OutPutEvent != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData($"progress:  {progress}"));
                    }
                    if (progress > 100) progress = 100;
                    SendResultEvent(true, null);
                    /* wait for ACK */
                    temp = (byte)serialPort.ReadByte();
                    if (temp != (byte)YModemMessageType.ACK)
                    {
                        if (OutPutEvent != null)
                        {
                            OutPutEvent(this, new TrackerReceiveData($"temp {temp}"));
                            OutPutEvent(this, new TrackerReceiveData($"Couldn't send a packet."));
                        }
                        Debug.WriteLine("temp" + temp);
                        Debug.WriteLine("Couldn't send a packet.");
                        SendResultEvent(true, null);
                        return;
                    }
                } while (dataSize == fileReadCount);

                /* send EOT (tell the downloader we are finished) */
                serialPort.Write(new byte[] { (byte)YModemMessageType.EOT }, 0, 1);
                /* send closing packet */
                packetNumber = 0;
                invertedPacketNumber = 255;
                data = new byte[dataSize];
                CRC = new byte[crcSize];
                SendClosingPacket(YModemMessageType.STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize);

                /* get ACK (downloader acknowledge the EOT) */
                if (serialPort.ReadByte() != (byte)YModemMessageType.ACK)
                {
                    Debug.WriteLine("Can't complete the transfer.");
                    if (OutPutEvent != null)
                    {
                        OutPutEvent(this, new TrackerReceiveData("Can't complete the transfer."));
                    }
                    SendResultEvent(true, null);
                    return;// false;
                }

            }
            catch (TimeoutException)
            {
                if (OutPutEvent != null)
                {
                    OutPutEvent(this, new TrackerReceiveData("Eductor does not answering"));
                }
                throw new Exception("Eductor does not answering");

            }
            finally
            {
                fileStream.Close();
                if (SendResultEvent != null)
                {
                    SendResultEvent(false, null);
                }
            }

            Debug.WriteLine("File transfer is succesful");
            if (OutPutEvent != null)
            {
                OutPutEvent(this, new TrackerReceiveData("File transfer is succesful"));
            }

            //serialPort.Close();

            return;// true;
        }


        public void SendInitialPacket(YModemMessageType STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, string path, FileStream fileStream, byte[] CRC, int crcSize)
        {
            string fileName = System.IO.Path.GetFileName(path);
            string fileSize = fileStream.Length.ToString();
            if (OutPutEvent != null)
            {
                OutPutEvent(this, new TrackerReceiveData($"fileSize {fileSize}"));
            }
            Debug.WriteLine("fileSize" + fileSize);

            /* add filename to data */
            int i;
            var fileNameData = fileName.ToCharArray();
            for (i = 0; i < fileName.Length && (fileNameData[i] != 0); i++)
            {
                data[i] = (byte)fileNameData[i];
            }

            data[i++] = 0;

            /* add filesize to data */
            int j;
            var fileSizeData = fileSize.ToCharArray();
            for (j = 0; j < fileSize.Length && (fileSizeData[j] != 0); j++)
            {
                data[i + j] = (byte)fileSizeData[j];
            }
            data[i + j] = 0;

            /* fill the remaining data bytes with 0 */
            for (int k = (i + j) + 1; k < dataSize; k++)
            {
                data[k] = 0;
            }

            /* calculate CRC */
            Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
            CRC = crc16Ccitt.ComputeChecksumBytes(data);

            /* send the packet */
            SendPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize);
        }

        private void SendPacket(YModemMessageType STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, byte[] CRC, int crcSize)
        {
            serialPort.Write(new byte[] { (byte)STX }, 0, 1);
            serialPort.Write(new byte[] { (byte)packetNumber }, 0, 1);
            Debug.WriteLine("\rpacketNumber:" + packetNumber);
            if (OutPutEvent != null)
            {
                OutPutEvent(this, new TrackerReceiveData($"packetNumber {packetNumber}"));
            }
            serialPort.Write(new byte[] { (byte)invertedPacketNumber }, 0, 1);
            Debug.WriteLine("\rinvertedPacketNumber:" + invertedPacketNumber);
            if (OutPutEvent != null)
            {
                OutPutEvent(this, new TrackerReceiveData($"invertedPacketNumber {invertedPacketNumber}"));
            }
            serialPort.Write(data, 0, dataSize);
            serialPort.Write(CRC, 0, crcSize);
        }

        private void SendClosingPacket(YModemMessageType STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, byte[] CRC, int crcSize)
        {
            /* calculate CRC */
            Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
            CRC = crc16Ccitt.ComputeChecksumBytes(data);

            /* send the packet */
            SendPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize);
        }
    }
}
