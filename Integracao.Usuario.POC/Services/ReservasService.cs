using System.Threading.Tasks;
using Integracao.Usuario.POC.Interfaces;
using Integracao.Usuario.POC.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Integracao.Usuario.POC.Services
{
    public class ReservasService : IReservaService
    {
        protected readonly IConfiguration _configuracao;
        protected readonly ILogger<ReservasService> _log;

        public ReservasService(ILogger<ReservasService> log, IConfiguration configuracao)
        {
            _log = log;
            _configuracao = configuracao;
        }

        public async Task<ObterRespostaResponse> Listar(ObterReservasRequest query)
        {
            return null;
        }
    }
}
