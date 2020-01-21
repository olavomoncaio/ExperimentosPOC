using Integracao.Usuario.POC.Interfaces;
using Integracao.Usuario.POC.Repositories;
using Integracao.Usuario.POC.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Integracao.Usuario.POC.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ConfigurarDependencias(this IServiceCollection services)
        {
            services.AddTransient<IReservaService, ReservasService>();
            services.AddTransient<IReservasRepository, ReservasRepository>();
            services.AddTransient<IHospedesRepository, HospedesRepository>();
            services.AddTransient<IAcompanhantesRepository, AcompanhantesRepository>();

            return services;
        }
    }
}
