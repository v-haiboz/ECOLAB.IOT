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
            //register configuration
            //IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
            //    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Appsetting"))
            //    .AddJsonFile(env.FileName);

            //IConfiguration configuration = cfgBuilder.Build();
            //services.AddSingleton<IConfiguration>(configuration);

            //services.AddOptions();
            //services.Configure<AppServiceOption>(configuration.GetSection("AppServiceOptions"));
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Appsetting", env.FileName);
            var json = File.ReadAllText(filePath);
            var appServiceOption = JsonConvert.DeserializeObject<AppServiceOption>(json);
            services.AddSingleton<AppServiceOption>(appServiceOption);
            return services;
        }

        public static ServiceCollection RegisterSecretClient(this ServiceCollection services, AppServiceOption appServiceOption)
        {
            var cliectSecret = new SecretClient(new Uri(appServiceOption.KeyValutUri)
                , new ClientSecretCredential(appServiceOption.TenantId, appServiceOption.ClientId, appServiceOption.ClientSecret));
            services.AddSingleton(cliectSecret);
            return services;
        }

        public static ServiceCollection RegisterCurrentSysAdmins(this ServiceCollection services, SysAdmins sysAdmins)
        {
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
