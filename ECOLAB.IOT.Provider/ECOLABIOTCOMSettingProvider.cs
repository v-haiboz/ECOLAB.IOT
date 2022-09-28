namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Entity;
    using System;
    using System.IO.Ports;

    public interface IECOLABIOTCOMSettingProvider
    {
        public COMSetting GetDefaultCOMSetting();
        public string[] GetPortNames();
        public string[] GetBaudRate();
        public string[] GetParityBit();
        public string[] GetDataBit();
        public string[] GetStopBit();
        public string[] GetTransportProtocol();

    }
    public class ECOLABIOTCOMSettingProvider : IECOLABIOTCOMSettingProvider
    {
        private static COMSetting setting = new COMSetting()
        {
            BaudRate = BaudRates.BR_115200,
            DataBit = DataBits.Eight,
            Parity = Parity.None,
            PortName = "COM3",
            StopBit = StopBits.One,
            TransportProtocol= TransportProtocol.Ymodem
        };
        public COMSetting GetDefaultCOMSetting()
        { 
           return setting;
        }
        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public string[] GetBaudRate()
        {
            return Enum.GetNames(typeof(BaudRates));
        }

        public string[] GetParityBit()
        {
            return Enum.GetNames(typeof(Parity));
        }

        public string[] GetDataBit()
        {
            return Enum.GetNames(typeof(DataBits));
        }

        public string[] GetStopBit()
        {
           return Enum.GetNames(typeof(StopBits));
        }

        public string[] GetTransportProtocol()
        {
             return Enum.GetNames(typeof(TransportProtocol));
        }
    }

}
