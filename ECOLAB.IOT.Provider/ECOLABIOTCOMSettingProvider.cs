namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using System;
    using System.IO.Ports;
    using System.Linq;
    using System.Text;

    public interface IECOLABIOTCOMSettingProvider
    {
        public COMSetting GetDefaultCOMSetting();
        public string[] GetPortNames();
        public string[] GetBaudRate();
        public string[] GetParityBit();
        public string[] GetDataBit();
        public string[] GetStopBit();
        public string[] GetTransportProtocol();
        public bool MemorySetting(COMSetting setting);

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
            return YamlDotNetExtesions.deserializer.Deserialize<COMSetting>(File.ReadAllText("COMSetData/defaultsetting.yaml"));
            //return setting;
        }

        public bool MemorySetting(COMSetting setting)
        {
            var yaml=YamlDotNetExtesions.serializer.Serialize(setting);
            var dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "COMSetData");
            try
            {
                var filePath =Path.Combine(dirPath, "defaultsetting.yaml");
                filePath = Path.GetFullPath(filePath);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                File.WriteAllText(filePath, yaml, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
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
            var dataBits = (int[])Enum.GetValues(typeof(DataBits));
            string[] arrStr = Array.ConvertAll<int, string>(dataBits, delegate (int input) { return input.ToString(); });
            return arrStr;
        }

        public string[] GetStopBit()
        {
           return GetStopBits();
        }

        public string[] GetTransportProtocol()
        {
             return Enum.GetNames(typeof(TransportProtocol));
        }

        private string[] GetStopBits()
        {
            return new string[] {
              "1","1.5","2"
           };
        }

    }

}
