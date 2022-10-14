namespace ECOLAB.IOT.Entity
{
    using System.IO.Ports;

    public class COMSetting
    {
        public string? PortName { get; set; }
        public BaudRates BaudRate { get; set; }
        public DataBits DataBit { get; set; }
        public Parity Parity { get; set; }
        public StopBits StopBit { get; set; }

        public TransportProtocol TransportProtocol { get; set; }
    }
    public enum BaudRates : int
    {
        BR_75 = 75,
        BR_110 = 110,
        BR_150 = 150,
        BR_300 = 300,
        BR_600 = 600,
        BR_1200 = 1200,
        BR_2400 = 2400,
        BR_4800 = 4800,
        BR_9600 = 9600,
        BR_14400 = 14400,
        BR_19200 = 19200,
        BR_28800 = 28800,
        BR_38400 = 38400,
        BR_56000 = 56000,
        BR_57600 = 57600,
        BR_115200 = 115200,
        BR_128000 = 128000,
        BR_230400 = 230400,
        BR_256000 = 256000
    }

    public enum DataBits : int
    {
        Five = 5,
        Six = 6,
        Sevent = 7,
        Eight = 8
    }

    public enum TransportProtocol { 
        //ASCII,
        //Binary,
        Xmodem,
        //Xmodem1k=1024,
        Ymodem,
       // Ymodem1k=128,
    }
}
