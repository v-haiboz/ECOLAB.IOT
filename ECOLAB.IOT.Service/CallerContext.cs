namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using ECOLAB.IOT.Provider;
    using Microsoft.Extensions.Options;

    public class CallerContext:CallerContextBase
    {
        public static EnvironmentVariable EnvironmentVariable => Resolve<EnvironmentVariable>();
        public static SysAdmins SysAdmins => Resolve<SysAdmins>();

        public static IOptions<AppServiceOptions> AppServiceOptionsWrapper => Resolve<IOptions<AppServiceOptions>>();
        public static IECOLABIOTUserProvider ECOLABIOTUserProvider => Resolve<IECOLABIOTUserProvider>();
        public static IECOLABIOTUserService ECOLABIOTUserService => Resolve<IECOLABIOTUserService>();
        
    }
}