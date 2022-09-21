namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using System;
    using System.Linq;
    public interface IECOLABIOTUserProvider
    {
        public SysAdminsList GetUsers();
        public bool? AdminLogin(SysAdmins sysAdmins);
    }
    public class ECOLABIOTUserProvider: IECOLABIOTUserProvider
    {
        public SysAdminsList GetUsers()
        {
            return YamlDotNetExtesions.deserializer.Deserialize<SysAdminsList>(File.ReadAllText("UserData/users.yaml"));
        }

        public bool? AdminLogin(SysAdmins sysAdmins)
        {
            var users = GetUsers();
            return users?.List?.ToList().Any(item => string.Equals(item?.Pwd, sysAdmins?.Pwd, StringComparison.Ordinal)
                                                   &&string.Equals(item?.UserName, sysAdmins?.UserName, StringComparison.Ordinal));
        }
    }
}
