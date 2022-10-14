namespace ECOLAB.IOT.Transmit.FileTransmit
{
    using System;
    using System.IO.Ports;

    public partial class YModem
    {
        const int dataSize = 1024;
        const int crcSize = 2;

        /* THE PACKET: 1029 bytes */
        /* header: 3 bytes */
        // STX
        int packetNumber = 0;
        int invertedPacketNumber = 255;
        /* data: 1024 bytes */
        byte[] data = new byte[dataSize];
        /* footer: 2 bytes */
        byte[] CRC = new byte[crcSize];

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

        public YModem(SerialPort serialPort, string path)
        {
            this.serialPort = serialPort;
            this.path = path;
        }

    }
}
