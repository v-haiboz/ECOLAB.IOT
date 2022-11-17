namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using System;
    using System.IO.Ports;

    public partial class XModem
    {
        byte[] Sender_Packet = new byte[3];
        byte[] Sender_Data = new byte[1024];
        byte[] Sender_Crc = new byte[2];
        byte[] Sender_EOT = new byte[1];
        ushort Sender_Crc_us;

        byte Sender_Packet_Number = 0;

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

        public event ITransmitUart.OutPutEventHandler OutPutEvent;
        public event EventHandler SendResultEvent;
        public event ITransmitUart.MessageBoxEventHandler MessageBoxEvent;

        public XModem(SerialPort serialPort, string path)
        {
            this.serialPort = serialPort;
            this.path = path;
        }

      
    }
}
