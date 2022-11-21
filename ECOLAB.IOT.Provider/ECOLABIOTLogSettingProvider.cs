namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using System;
    using System.Linq;
    public interface IECOLABIOTLogSettingProvider
    {
        public LogSetting GetLogSetting();
    }
    public class ECOLABIOTLogSettingProvider : IECOLABIOTLogSettingProvider
    {
        public LogSetting GetLogSetting()
        {
            return YamlDotNetExtesions.deserializer.Deserialize<LogSetting>(File.ReadAllText("Logsetting/logsetting.yaml"));
        }
    }
}
