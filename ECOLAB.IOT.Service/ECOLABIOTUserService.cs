namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;

    public interface IECOLABIOTUserService
    {
        public bool? AdminLogin(SysAdmin sysAdmins);
        public SysAdmin? GetUser(SysAdmin sysAdmins);
    }
    public class ECOLABIOTUserService : IECOLABIOTUserService
    {
        public bool? AdminLogin(SysAdmin sysAdmin)
        {
            return CallerContext.ECOLABIOTUserProvider.AdminLogin(sysAdmin);
        }
        public SysAdmin? GetUser(SysAdmin sysAdmin)
        {
            return CallerContext.ECOLABIOTUserProvider.GetUser(sysAdmin);
        }
    }
}
