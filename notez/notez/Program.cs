using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace notez
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceCollection services = new();
            ConfigureServices(services);
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<FormBusCollection>());
        }
        private static void ConfigureServices(ServiceCollection services) 
        {
            services.AddSingleton<FormBusCollection>()
                    .AddLogging(option =>
                    {
                        option.SetMinimumLevel(LogLevel.Information);
                        option.AddNLog("nlog.config");
                    });
        }

    }
}   