using System.Threading.Tasks;
using Integracao.Usuario.POC.Models;

namespace Integracao.Usuario.POC.Interfaces
{
    public interface IReservaService
    {
        Task<BaseResponse> ListarReservas(ObterReservasRequest query);
    }
}