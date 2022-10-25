namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using System.Text;

    public interface IECOLABIOTAADSettingProvider
    {
        AADSetting GetAADSetting();

        bool? AddOrUpdateAADSetting(AADSetting setting);

    }
    public class ECOLABIOTAADSettingProvider : IECOLABIOTAADSettingProvider
    {
        public AADSetting GetAADSetting()
        {
            return YamlDotNetExtesions.deserializer.Deserialize<AADSetting>(File.ReadAllText("Appsetting/addsetting.yaml"));
        }

        public bool? AddOrUpdateAADSetting(AADSetting setting)
        {
            if (setting == null)
            {
                return false;
            }
            var settingYmal = YamlDotNetExtesions.serializer.Serialize(setting);
            File.WriteAllText("Appsetting/addsetting.yaml", settingYmal, Encoding.UTF8);
            return true;
        }
    }
}
