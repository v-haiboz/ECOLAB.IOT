namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using System;
    using System.IO.Ports;

    public partial class Xmodem1k
    {
        byte[] Sender_Packet = new byte[3];
        byte[] Sender_Data = new byte[1024];
        byte[] Sender_Crc = new byte[2];
        byte[] Sender_EOT = new byte[1];
        ushort Sender_Crc_us;

        byte Sender_Packet_Number = 0;
        int Sender_Packet_Number_Total = 0;
        private string path;
        public string Path
        {
            get
            {
                return Path;
            }
            set
            {
                path = value;
            }
        }
        private SerialPort serialPort = new SerialPort();

        public event IFileTransmit.OutPutEventHandler OutPutEvent;
        public event EventHandler SendResultEvent;
        public event IFileTransmit.MessageBoxEventHandler MessageBoxEvent;
        public event IFileTransmit.Transforer OutTransforer;
        private bool isCRC = false;
        public Xmodem1k(SerialPort serialPort, string path,bool isCRC=false)
        {
            this.serialPort = serialPort;
            this.serialPort.WriteTimeout = 10000;
            this.path = path;
            Sender_EOT[0] = (byte)XModemMessageType.EOT;
            this.isCRC = isCRC;
        }
    }
}
