namespace ECOLAB.IOT.Entity
{
    using System;
    public class EnvironmentVariable
    {
        public string Name { get; set; } = "";
        public string FileName { get; set; } = "";
        public string FilePath { get; set; } = "";
        public AppServiceOption AppServiceOption { get; set; } = null;
    }
}
