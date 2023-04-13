namespace ECOLAB.IOT.Entity
{
    using YamlDotNet.Serialization;

    public class LogSetting
    {
        [YamlMember(Alias = "enable")]
        public bool Enable { get; set; }

        //Login UserName
        [YamlMember(Alias = "deviceLogContinuity")]
        public bool DeviceLogContinuity { get; set; }

        [YamlMember(Alias = "debug")]
        public bool Debug { get; set; }
    }
}
