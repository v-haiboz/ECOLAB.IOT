namespace ECOLAB.IOT.Provider
{
    using ECOLAB.IOT.Common;
    using ECOLAB.IOT.Common.Utilities;
    using ECOLAB.IOT.Entity;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IECOLABIOTEnvironmentProvider
    {
        List<EnvironmentVariable> GetEnvironmentVariables();

        bool AddOrUpdateEnvironmentVariable(EnvironmentVariable environmentVariable);

        bool RemoveEnvironmentVariable(EnvironmentVariable environmentVariable);

    }

    public class ECOLABIOTEnvironmentProvider : IECOLABIOTEnvironmentProvider
    {
        
        public bool AddOrUpdateEnvironmentVariable(EnvironmentVariable environmentVariable)
        {
            if (environmentVariable.IsNull())
            {
                return false;
            }

            var appServiceOptionJson = JsonConvert.SerializeObject(environmentVariable.AppServiceOption);
            File.WriteAllText(environmentVariable.FilePath, appServiceOptionJson, Encoding.UTF8);
            return true;
        }

        public List<EnvironmentVariable> GetEnvironmentVariables()
        {
            var list = new List<EnvironmentVariable>();
            var dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Appsetting");

            foreach (var filePath in Directory.GetFiles(dirPath))
            {

                var fileName = Path.GetFileName(filePath);
                var json = File.ReadAllText(filePath);
                var appServiceOption = JsonConvert.DeserializeObject<AppServiceOption>(json);
               // IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
               //.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Appsetting"))
               //.AddJsonFile(fileName);
               // IConfiguration configuration = cfgBuilder.Build();

                // var appServiceOption = new AppServiceOption()
                // {
                //     ClientId = configuration.GetSection("AppServiceOptions:ClientId").Value,
                //     ClientSecret = configuration.GetSection("AppServiceOptions:ClientSecret").Value,
                //     TenantId = configuration.GetSection("AppServiceOptions:TenantId").Value,
                //     KeyValutUri = configuration.GetSection("AppServiceOptions:KeyValutUri").Value
                // };
                var name = fileName.Replace("appsetting_", "").Replace(".json", "");
                list.Add(new EnvironmentVariable()
                {
                    AppServiceOption = appServiceOption,
                    Name = name,
                    FileName = fileName,
                    FilePath = filePath
                });
            }

            return list;
        }

        public bool RemoveEnvironmentVariable(EnvironmentVariable environmentVariable)
        {
            if (environmentVariable==null || string.IsNullOrEmpty(environmentVariable.Name))
            {
                return false;
            }
            var dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Appsetting");
            try
            {
                var filePath = string.Format(Constants.FilePathTemplate, AppDomain.CurrentDomain.BaseDirectory, string.Format(Constants.FileNameTemplate, environmentVariable.Name));
                filePath = Path.GetFullPath(filePath);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
