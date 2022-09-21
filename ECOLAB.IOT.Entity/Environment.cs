namespace ECOLAB.IOT.Entity
{
    using System;
    public class EnvironmentVariable
    {
        public EnvironmentName Name { get; set; } = EnvironmentName.INT;
    }
    public enum EnvironmentName
    {
        INT=1,
        PRODUCT=2
    }

}
