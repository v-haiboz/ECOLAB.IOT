
namespace ECOLAB.IOT.Entity
{
    using System.Collections.Generic;
    using YamlDotNet.Serialization;

    public class DeviceTypMapping
    {
        [YamlMember(Alias = "mappings")]
        public List<DeviceType>? List { get; set; }=new List<DeviceType>();
    }

    public class DeviceType
    {
        [YamlMember(Alias = "sourcenamelist")]
        public List<string> SourceNameList { get; set; } = new List<string>();

        [YamlMember(Alias = "targetname")]
        public string TargetName { get; set; }
    }

    public class DeviceTypeMappingDisplay
    {
        public string TargetPrefix { get; set; }
        public string SourcePrefixs { get; set; }
    }
}
