namespace ECOLAB.IOT.WinFormApp
{
    using ECOLAB.IOT.Entity;
    using ECOLAB.IOT.Provider;
    using ECOLAB.IOT.Service;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

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
            services.AddSingleton<EnvironmentVariable>(env => (EnvironmentVariable)env);
            return services;
        }

        public static ServiceCollection RegisterAppsetting(this ServiceCollection services, EnvironmentVariable env)
        {
            //register configuration
            IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"Appsetting"))
                .AddJsonFile($"appsetting_{env.Name}.json");

            IConfiguration configuration = cfgBuilder.Build();
            services.AddSingleton<IConfiguration>(configuration);

            services.AddOptions();
            services.Configure<AppServiceOptions>(configuration.GetSection("AppServiceOptions"));

            return services;
        }



        public static ServiceCollection RegisterCurrentSysAdmins(this ServiceCollection services, SysAdmins sysAdmins)
        {
            services.AddScoped<SysAdmins>(sp => sysAdmins);
            return services;
        }

        private static ServiceCollection RegisterProvider(this ServiceCollection services)
        {
            //注册 FormMain 类
            services.AddScoped<IECOLABIOTUserProvider, ECOLABIOTUserProvider>();
            return services;
        }
        private static ServiceCollection RegisterService(this ServiceCollection services)
        {
            //注册 FormMain 类
            services.AddScoped<IECOLABIOTUserService, ECOLABIOTUserService>();
            return services;
        }
        
        public static void Build(this ServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            Common.Utilities.CallerContextBase.Container = serviceProvider;
        }
    }
}
