namespace ECOLAB.IOT.WinFormApp
{
    using Azure.Identity;
    using Azure.Security.KeyVault.Secrets;
    using ECOLAB.IOT.Entity;
    using ECOLAB.IOT.Provider;
    using ECOLAB.IOT.Service;
    using Microsoft.Extensions.DependencyInjection;
    using Newtonsoft.Json;
    using System;

    internal static class ServiceCollectionExtension
    {
        private static ServiceCollection services = new ServiceCollection();
        public static ServiceCollection GetCurrentServiceCollection()
        {
            return services;
        }

        public static ServiceCollection ConfigureService(this ServiceCollection services)
        {
            return services.RegisterService()
                           .RegisterProvider();
        }

        public static ServiceCollection RegisterCurrentEnvironment(this ServiceCollection services, EnvironmentVariable env)
        {
            services.AddSingleton(env);
            return services;
        }

        public static ServiceCollection RegisterAppsetting(this ServiceCollection services, EnvironmentVariable env)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Appsetting", env.FileName);
            var json = File.ReadAllText(filePath);
            var appServiceOption = JsonConvert.DeserializeObject<AppServiceOption>(json);
            appServiceOption=CallerContext.ECOLABIOTEnvironmentService.DecryptAppServiceOption(appServiceOption);
            services.AddSingleton<AppServiceOption>(appServiceOption);
            return services;
        }

        public static ServiceCollection RegisterSecretClient(this ServiceCollection services, AppServiceOption appServiceOption)
        {
            var cliectSecret = new SecretClient(new Uri(appServiceOption.KeyValutUrl), 
                new ClientSecretCredential(appServiceOption.TenantId, appServiceOption.ClientId, appServiceOption.ClientSecret, new TokenCredentialOptions
                {
                    AuthorityHost = AzureAuthorityHosts.AzureChina
                }));

            services.AddSingleton(cliectSecret);
            return services;
        }

        public static ServiceCollection RegisterCurrentSysAdmins(this ServiceCollection services, SysAdmin? sysAdmins)
        {
            if(sysAdmins!=null)
            services.AddSingleton(sysAdmins);
            return services;
        }

        private static ServiceCollection RegisterProvider(this ServiceCollection services)
        {
            //Register Provider
            services.AddScoped<IECOLABIOTUserProvider, ECOLABIOTUserProvider>();
            services.AddScoped<IECOLABIOTSerialPortProvider, ECOLABIOTSerialPortProvider>();
            services.AddScoped<IECOLABIOTCOMSettingProvider, ECOLABIOTCOMSettingProvider>();
            services.AddScoped<IECOLABIOTEnvironmentProvider, ECOLABIOTEnvironmentProvider>();
            services.AddScoped<IECOLABIOTRegisterDeviceProvider, ECOLABIOTRegisterDeviceProvider>();
            services.AddSingleton<IECOLABIOTSecurityProvider, ECOLABIOTSecurityProvider>();
            return services;
        }
        private static ServiceCollection RegisterService(this ServiceCollection services)
        {
            //Register Service
            services.AddScoped<IECOLABIOTUserService, ECOLABIOTUserService>();
            services.AddScoped<IECOLABIOTBurnSNAndPSKService, ECOLABIOTBurnSNAndPSKService>();
            services.AddScoped<IECOLABIOTSecretService, ECOLABIOTSecretService>();
            services.AddScoped<IECOLABIOTEnvironmentService, ECOLABIOTEnvironmentService>();
            services.AddScoped<IECOLABIOTRegisterDeviceService, ECOLABIOTRegisterDeviceService>();
            return services;
        }

        public static void Build(this ServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            Common.Utilities.CallerContextBase.Container = serviceProvider;
        }
    }
}
