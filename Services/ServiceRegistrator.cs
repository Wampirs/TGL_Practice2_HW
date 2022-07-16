using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGL_Practice2_HW.Services.Interfaces;

namespace TGL_Practice2_HW.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IProgramEngine, ProgramEngine>()
            .AddTransient<IUserDialog, UserDialog>()
             ;

    }
}
