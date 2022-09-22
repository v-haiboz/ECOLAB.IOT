namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;
    using System;
    public interface IECOLABIOTBurnSNAndPSKService
    {
        public COMSetting GetDefaultCOMSetting();
        public string[] GetPortNames();
        public string[] GetBaudRate();
        public string[] GetParityBit();
        public string[] GetDataBit();
        public string[] GetStopBit();
    }

    public class ECOLABIOTBurnSNAndPSKService : IECOLABIOTBurnSNAndPSKService
    {
        public COMSetting GetDefaultCOMSetting()
        {
            return CallerContext.ECOLABIOTCOMSettingProvider.GetDefaultCOMSetting();
        }

        public string[] GetPortNames()
        {
           return CallerContext.ECOLABIOTSerialPortProvider.GetPortNames();
        }

        public string[] GetBaudRate()
        {
            return CallerContext.ECOLABIOTCOMSettingProvider.GetBaudRate();
        }

        public string[] GetParityBit()
        {
            return CallerContext.ECOLABIOTCOMSettingProvider.GetParityBit();
        }
        public string[] GetDataBit()
        {
            return CallerContext.ECOLABIOTCOMSettingProvider.GetDataBit();
        }
        public string[] GetStopBit()
        {
            return CallerContext.ECOLABIOTCOMSettingProvider.GetStopBit();
        }
    }
}
