namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;

    public interface IECOLABIOTLogSettingService
    {
        public LogSetting GetLogSetting();
    }
    public class ECOLABIOTLogSettingService : IECOLABIOTLogSettingService
    {
        public LogSetting GetLogSetting()
        {
            return CallerContext.ECOLABIOTLogSettingProvider.GetLogSetting();
        }
    }
}
