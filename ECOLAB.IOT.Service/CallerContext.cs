﻿namespace ECOLAB.IOT.Service
{
    using Azure.Security.KeyVault.Secrets;
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using ECOLAB.IOT.Provider;

    public class CallerContext:CallerContextBase
    {
        public static EnvironmentVariable EnvironmentVariable => Resolve<EnvironmentVariable>();
        public static AppServiceOption AppServiceOptions => Resolve<AppServiceOption>();
        
        public static SysAdmin SysAdmin => Resolve<SysAdmin>();



        public static IECOLABIOTUserService ECOLABIOTUserService => Resolve<IECOLABIOTUserService>();
        public static IECOLABIOTBurnSNAndPSKService ECOLABIOTBurnSNAndPSKService => Resolve<IECOLABIOTBurnSNAndPSKService>();
        public static IECOLABIOTSecretService ECOLABIOTSecretService => Resolve<IECOLABIOTSecretService>();
        public static IECOLABIOTEnvironmentService ECOLABIOTEnvironmentService => Resolve<IECOLABIOTEnvironmentService>();
        public static IECOLABIOTRegisterDeviceService ECOLABIOTRegisterDeviceService => Resolve<IECOLABIOTRegisterDeviceService>();
        public static IECOLABIOTDeviceTypeService ECOLABIOTDeviceTypeService => Resolve<IECOLABIOTDeviceTypeService>();



        public static IECOLABIOTUserProvider ECOLABIOTUserProvider => Resolve<IECOLABIOTUserProvider>();
        public static IECOLABIOTSerialPortProvider ECOLABIOTSerialPortProvider => Resolve<IECOLABIOTSerialPortProvider>();
        public static IECOLABIOTCOMSettingProvider ECOLABIOTCOMSettingProvider => Resolve<IECOLABIOTCOMSettingProvider>();
        public static SecretClient ECOLABIOTSecretClient => Resolve<SecretClient>();
        public static IECOLABIOTEnvironmentProvider ECOLABIOTEnvironmentProvider => Resolve<IECOLABIOTEnvironmentProvider>();
        public static IECOLABIOTRegisterDeviceProvider ECOLABIOTRegisterDeviceProvider => Resolve<IECOLABIOTRegisterDeviceProvider>();
        public static IECOLABIOTSecurityProvider ECOLABIOTSecurityProvider => Resolve<IECOLABIOTSecurityProvider>();
        public static IECOLABIOTDeviceTypeProvider ECOLABIOTDeviceTypeProvider => Resolve<IECOLABIOTDeviceTypeProvider>();
    }
}