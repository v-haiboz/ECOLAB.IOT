namespace ECOLAB.IOT.Entity
{
    using YamlDotNet.Serialization;
    public class SysAdminList
    {
        [YamlMember(Alias = "Users")]
        public HashSet<SysAdmin>? List { get; set; }
    }
    public class SysAdmin
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

        /// <summary>
        /// IsSuper
        /// </summary>
        private bool isSuper = false;
        [YamlMember(Alias = "IsSuper")]
        public bool IsSuper
        {
            get
            {
                return isSuper && UserName.StartsWith("Admin");
            }
            set
            {
                isSuper = value;
            }
        }
    }
}