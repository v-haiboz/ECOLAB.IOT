namespace ECOLAB.IOT.Entity
{
    using YamlDotNet.Serialization;
    public class SysAdminsList
    {
        [YamlMember(Alias = "Users")]
        public HashSet<SysAdmins>? List { get; set; }
    }
    public class SysAdmins
    {
        //Login ID
        [YamlMember(Alias = "LoginId")]
        public int LoginId { get; set; }

        //Login UserName
        [YamlMember(Alias = "UserName")]
        public string? UserName { get; set; }

        //Login Password
        [YamlMember(Alias = "Pwd")]
        public string? Pwd { get; set; }

        /// <summary>
        /// Role
        /// </summary>
        [YamlMember(Alias = "Role")]
        public int Role { get; set; }
    }
}