using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Integracao.Usuario.POC.Configurations
{
    public static class HealthCheckConfiguration
    {
        public static IServiceCollection ConfigurarHealthChecks(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
            .AddSqlServer(configuration.GetConnectionString("Hotelaria"), name: "Hotelaria");

            return services;
        }
    }
}
