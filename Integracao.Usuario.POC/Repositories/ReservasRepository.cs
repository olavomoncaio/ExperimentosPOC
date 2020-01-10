using Integracao.Usuario.POC.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Integracao.Usuario.POC.Repositories
{
    public sealed class ReservasRepository : RepositoryBase, IReservasRepository
    {
        public ReservasRepository(IConfiguration configuration) : base(configuration)
        {
        }

    }
}
