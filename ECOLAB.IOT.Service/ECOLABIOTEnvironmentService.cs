namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;
    using System;
    using System.Collections.Generic;

    public interface IECOLABIOTEnvironmentService
    {
        List<EnvironmentVariable> GetEnvironmentVariables();

        bool AddOrUpdateEnvironmentVariable(EnvironmentVariable environmentVariable);

        EnvironmentVariable? GetEnvironmentVariableByName(string name);

        bool RemoveEnvironmentVariable(EnvironmentVariable environmentVariable);

    }

    public class ECOLABIOTEnvironmentService : IECOLABIOTEnvironmentService
    {
        public bool AddOrUpdateEnvironmentVariable(EnvironmentVariable environmentVariable)
        {
            return CallerContext.ECOLABIOTEnvironmentProvider.AddOrUpdateEnvironmentVariable(environmentVariable);
        }

        public EnvironmentVariable? GetEnvironmentVariableByName(string name)
        {
            var list = CallerContext.ECOLABIOTEnvironmentProvider.GetEnvironmentVariables();
            return list.Where(item=>item.Name==name).FirstOrDefault();
        }

        public List<EnvironmentVariable> GetEnvironmentVariables()
        {
            var list = CallerContext.ECOLABIOTEnvironmentProvider.GetEnvironmentVariables();
            return list;
        }

        public bool RemoveEnvironmentVariable(EnvironmentVariable environmentVariable)
        {
            return CallerContext.ECOLABIOTEnvironmentProvider.RemoveEnvironmentVariable(environmentVariable);
        }
    }
}
