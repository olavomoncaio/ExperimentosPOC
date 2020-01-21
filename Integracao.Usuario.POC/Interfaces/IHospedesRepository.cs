using Integracao.Usuario.POC.Dto;
using System.Threading.Tasks;

namespace Integracao.Usuario.POC.Interfaces
{
    public interface IHospedesRepository
    {
        Task<HospedeDto> ObterHospede(int hospedeId);
    }
}
