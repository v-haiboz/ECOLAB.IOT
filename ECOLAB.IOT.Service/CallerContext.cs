namespace ECOLAB.IOT.Service
{
    using Azure.Security.KeyVault.Secrets;
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using ECOLAB.IOT.Provider;
    using Microsoft.Extensions.Options;

    public class CallerContext:CallerContextBase
    {
        public static EnvironmentVariable EnvironmentVariable => Resolve<EnvironmentVariable>();
        public static AppServiceOptions AppServiceOptions => Resolve<AppServiceOptions>();
        
        public static SysAdmins SysAdmins => Resolve<SysAdmins>();

        public static IOptions<AppServiceOptions> AppServiceOptionsWrapper => Resolve<IOptions<AppServiceOptions>>();


        public static IECOLABIOTUserService ECOLABIOTUserService => Resolve<IECOLABIOTUserService>();
        public static IECOLABIOTBurnSNAndPSKService ECOLABIOTBurnSNAndPSKService => Resolve<IECOLABIOTBurnSNAndPSKService>();
        public static IECOLABIOTSecretService ECOLABIOTSecretService => Resolve<IECOLABIOTSecretService>();
        

        public static IECOLABIOTUserProvider ECOLABIOTUserProvider => Resolve<IECOLABIOTUserProvider>();
        public static IECOLABIOTSerialPortProvider ECOLABIOTSerialPortProvider => Resolve<IECOLABIOTSerialPortProvider>();
        public static IECOLABIOTCOMSettingProvider ECOLABIOTCOMSettingProvider => Resolve<IECOLABIOTCOMSettingProvider>();
        public static SecretClient ECOLABIOTSecretClient => Resolve<SecretClient>();

    }
}