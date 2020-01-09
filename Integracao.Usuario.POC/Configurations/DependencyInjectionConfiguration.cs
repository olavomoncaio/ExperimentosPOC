using Integracao.Usuario.POC.Interfaces;
using Integracao.Usuario.POC.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Integracao.Usuario.POC.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ConfigurarDependencias(this IServiceCollection services)
        {
            services.AddTransient<IReservaService, ReservasService>();

            return services;
        }
    }
}
