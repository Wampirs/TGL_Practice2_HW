using Microsoft.Extensions.DependencyInjection;
using TGL_Practice2_HW.Services.Interfaces;

namespace TGL_Practice2_HW.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IProgramEngine, ProgramEngine>()
            .AddTransient<IUserDialog, UserDialog>()
            .AddTransient<IFightEngine,FightEngine>()

             ;

    }
}
