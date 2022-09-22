namespace ECOLAB.IOT.WinFormApp
{
    using ECOLAB.IOT.Entity;
    using ECOLAB.IOT.Provider;
    using ECOLAB.IOT.Service;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System.CodeDom;

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
            IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Appsetting"))
                .AddJsonFile($"appsetting_{env.Name}.json");

            IConfiguration configuration = cfgBuilder.Build();
            services.AddSingleton<IConfiguration>(configuration);

            services.AddOptions();
            services.Configure<AppServiceOptions>(configuration.GetSection("AppServiceOptions"));

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
            return services;
        }
        private static ServiceCollection RegisterService(this ServiceCollection services)
        {
            //Register Service
            services.AddScoped<IECOLABIOTUserService, ECOLABIOTUserService>();
            services.AddScoped<IECOLABIOTBurnSNAndPSKService, ECOLABIOTBurnSNAndPSKService>();
            return services;
        }

        public static void Build(this ServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            Common.Utilities.CallerContextBase.Container = serviceProvider;
        }
    }
}
