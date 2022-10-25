namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;

    public interface IECOLABIOTADDSettingService
    {
        AADSetting GetAADSetting();

        bool? AddOrUpdateAADSetting(AADSetting setting);

    }

    public class ECOLABIOTADDSettingService : IECOLABIOTADDSettingService
    {
        public AADSetting GetAADSetting()
        {
            var setting=CallerContext.ECOLABIOTAADSettingProvider.GetAADSetting();
            return DecryptAADSetting(setting);
        }

        public bool? AddOrUpdateAADSetting(AADSetting setting)
        {
            if (setting == null)
            {
                return false;
            }

            return CallerContext.ECOLABIOTAADSettingProvider.AddOrUpdateAADSetting(EncryptAADSetting(setting));
        }

        public AADSetting EncryptAADSetting(AADSetting setting)
        {
            if (setting == null)
                return setting;

            var securityProvider = CallerContext.ECOLABIOTSecurityProvider;
            if (setting.ClientId != null)
                setting.ClientId = securityProvider.AESEncrypt(setting.ClientId);
            if (setting.TenantId != null)
                setting.TenantId = securityProvider.AESEncrypt(setting.TenantId);
            if (setting.Instance != null)
                setting.Instance = securityProvider.AESEncrypt(setting.Instance);

            return setting;
        }

        public AADSetting DecryptAADSetting(AADSetting setting)
        {
            if (setting == null)
                return setting;

            var securityProvider = CallerContext.ECOLABIOTSecurityProvider;
            if (setting.ClientId != null)
                setting.ClientId = securityProvider.AESDecrypt(setting.ClientId);
            if (setting.TenantId != null)
                setting.TenantId = securityProvider.AESDecrypt(setting.TenantId);
            if (setting.Instance != null)
                setting.Instance = securityProvider.AESDecrypt(setting.Instance);

            return setting;
        }
    }
}
