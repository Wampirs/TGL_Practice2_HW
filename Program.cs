using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TGL_Practice2_HW.Providers;
using TGL_Practice2_HW.Services;
using TGL_Practice2_HW.Services.Interfaces;

namespace TGL_Practice2_HW
{
    internal class Program
    {
        private static IHost host;
        public static IHost Host => host ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
        public static IServiceProvider Services => Host.Services;



        static void Main(string[] args)
        {
            Services.GetService<IProgramEngine>().StartGame();
        }





        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var hostBuilder = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                .ConfigureServices(ConfigureServices)
                ;
            return hostBuilder;
        }
        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services) => services
            .AddServices()
            .AddProviders()
            ;
    }
}