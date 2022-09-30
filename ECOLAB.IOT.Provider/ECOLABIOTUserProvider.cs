namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using System;
    using System.Linq;
    public interface IECOLABIOTUserProvider
    {
        public SysAdminList GetUsers();
        public bool? AdminLogin(SysAdmin sysAdmin);
        public SysAdmin? GetUser(SysAdmin sysAdmin);
    }
    public class ECOLABIOTUserProvider: IECOLABIOTUserProvider
    {
        public SysAdminList GetUsers()
        {
            return YamlDotNetExtesions.deserializer.Deserialize<SysAdminList>(File.ReadAllText("UserData/users.yaml"));
        }

        public bool? AdminLogin(SysAdmin sysAdmin)
        {
            var users = GetUsers();
            return users?.List?.ToList().Any(item => string.Equals(item?.Pwd, Utilities.HashCode(sysAdmin.Pwd), StringComparison.Ordinal)
                                                   &&string.Equals(item?.UserName, sysAdmin?.UserName, StringComparison.Ordinal));
        }
        public SysAdmin? GetUser(SysAdmin sysAdmin)
        {
            var users = GetUsers();
            return users?.List?.ToList().Where(item => string.Equals(item?.Pwd, Utilities.HashCode(sysAdmin.Pwd), StringComparison.Ordinal)
                                                   && string.Equals(item?.UserName, sysAdmin?.UserName, StringComparison.Ordinal)).FirstOrDefault();
        }
    }
}
