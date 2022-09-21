namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;

    public interface IECOLABIOTUserService
    {
        public bool? AdminLogin(SysAdmins sysAdmins);
    }
    public class ECOLABIOTUserService : IECOLABIOTUserService
    {
        public bool? AdminLogin(SysAdmins sysAdmins)
        {
            return CallerContext.ECOLABIOTUserProvider.AdminLogin(sysAdmins);
        }
    }
}
