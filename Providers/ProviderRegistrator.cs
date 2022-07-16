using Microsoft.Extensions.DependencyInjection;
using TGL_Practice2_HW.Providers.Interfaces;

namespace TGL_Practice2_HW.Providers
{
    internal static class ProviderRegistrator
    {
        public static IServiceCollection AddProviders (this IServiceCollection settings)=>settings
            .AddSingleton<IHeroProvider,HeroProvider> ()
            .AddTransient<IItemProvider,ItemProvider> ()
            ;
    }
}
