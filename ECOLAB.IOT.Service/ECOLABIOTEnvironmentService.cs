namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;
    using System.Collections.Generic;

    public interface IECOLABIOTEnvironmentService
    {
        List<EnvironmentVariable> GetEnvironmentVariables();

        bool AddOrUpdateEnvironmentVariable(EnvironmentVariable environmentVariable);

        EnvironmentVariable? GetEnvironmentVariableByName(string name);

        bool RemoveEnvironmentVariable(EnvironmentVariable environmentVariable);

        EnvironmentVariable EncryptEnvironmentVariable(EnvironmentVariable environmentVariable);

        EnvironmentVariable DecryptEnvironmentVariable(EnvironmentVariable appServiceOption);

        AppServiceOption DecryptAppServiceOption(AppServiceOption appServiceOption);

    }

    public class ECOLABIOTEnvironmentService : IECOLABIOTEnvironmentService
    {
        public bool AddOrUpdateEnvironmentVariable(EnvironmentVariable environmentVariable)
        {

            return CallerContext.ECOLABIOTEnvironmentProvider.AddOrUpdateEnvironmentVariable(EncryptEnvironmentVariable(environmentVariable));
        }

        public EnvironmentVariable? GetEnvironmentVariableByName(string name)
        {

            var list = CallerContext.ECOLABIOTEnvironmentProvider.GetEnvironmentVariables();
            var result = list.Where(item => item.Name == name).FirstOrDefault();
            result=DecryptEnvironmentVariable(result);
            return result;
        }

        public List<EnvironmentVariable> GetEnvironmentVariables()
        {
            var list = CallerContext.ECOLABIOTEnvironmentProvider.GetEnvironmentVariables();
            list = list?.Select(item => { return DecryptEnvironmentVariable(item); }).ToList();
            return list;
        }

        public bool RemoveEnvironmentVariable(EnvironmentVariable environmentVariable)
        {
            return CallerContext.ECOLABIOTEnvironmentProvider.RemoveEnvironmentVariable(environmentVariable);
        }

        public EnvironmentVariable EncryptEnvironmentVariable(EnvironmentVariable environmentVariable)
        {
            if (environmentVariable == null || environmentVariable.AppServiceOption==null)
                return environmentVariable;

            var securityProvider = CallerContext.ECOLABIOTSecurityProvider;
            environmentVariable.AppServiceOption.ClientId = securityProvider.AESEncrypt(environmentVariable.AppServiceOption.ClientId);
            environmentVariable.AppServiceOption.ClientSecret = securityProvider.AESEncrypt(environmentVariable.AppServiceOption.ClientSecret);
            environmentVariable.AppServiceOption.SecretExpireTime = securityProvider.AESEncrypt(environmentVariable.AppServiceOption.SecretExpireTime);
            environmentVariable.AppServiceOption.TenantId = securityProvider.AESEncrypt(environmentVariable.AppServiceOption.TenantId);
            environmentVariable.AppServiceOption.KeyValutUrl = securityProvider.AESEncrypt(environmentVariable.AppServiceOption.KeyValutUrl);
            environmentVariable.AppServiceOption.PlatformName = securityProvider.AESEncrypt(environmentVariable.AppServiceOption.PlatformName);
            environmentVariable.AppServiceOption.DeviceRegisterUrl = securityProvider.AESEncrypt(environmentVariable.AppServiceOption.DeviceRegisterUrl);

            return environmentVariable;
        }

        public EnvironmentVariable DecryptEnvironmentVariable(EnvironmentVariable environmentVariable)
        {
            if (environmentVariable == null || environmentVariable.AppServiceOption==null)
                return environmentVariable;

            environmentVariable.AppServiceOption = DecryptAppServiceOption(environmentVariable.AppServiceOption);

            return environmentVariable;

        }

        public AppServiceOption DecryptAppServiceOption(AppServiceOption appServiceOption)
        {
            if (appServiceOption != null)
            {
                var securityProvider = CallerContext.ECOLABIOTSecurityProvider;
                appServiceOption.ClientId = securityProvider.AESDecrypt(appServiceOption.ClientId);
                appServiceOption.ClientSecret = securityProvider.AESDecrypt(appServiceOption.ClientSecret);
                appServiceOption.SecretExpireTime = securityProvider.AESDecrypt(appServiceOption.SecretExpireTime);
                appServiceOption.TenantId = securityProvider.AESDecrypt(appServiceOption.TenantId);
                appServiceOption.KeyValutUrl = securityProvider.AESDecrypt(appServiceOption.KeyValutUrl);
                appServiceOption.PlatformName = securityProvider.AESDecrypt(appServiceOption.PlatformName);
                appServiceOption.DeviceRegisterUrl = securityProvider.AESDecrypt(appServiceOption.DeviceRegisterUrl);
            }

            return appServiceOption;
        }
    }
}
