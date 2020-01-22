using AutoMapper;
using Integracao.Usuario.POC.Interfaces;
using Integracao.Usuario.POC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integracao.Usuario.POC.Services
{
    public class ReservasService : IReservaService
    {
        protected readonly IConfiguration _configuracao;
        protected readonly ILogger<ReservasService> _log;
        protected readonly IMapper _mapper;
        protected readonly IReservasRepository _reservasRepository;
        protected readonly IHospedesRepository _hospedesRepository;
        protected readonly IAcompanhantesRepository _acompanhantesRepository;

        public ReservasService(ILogger<ReservasService> log, IConfiguration configuracao, IMapper mapper, 
            IReservasRepository reservasRepository, IHospedesRepository hospedesRepository, IAcompanhantesRepository acompanhantesRepository)
        {
            _log = log;
            _configuracao = configuracao;
            _mapper = mapper;
            _reservasRepository = reservasRepository;
            _hospedesRepository = hospedesRepository;
            _acompanhantesRepository = acompanhantesRepository;
        }

        public async Task<BaseResponse> ListarReservas(ObterReservasRequest query)
        {
            var hospedeDto = await _hospedesRepository.ObterHospede(query.HospedeId);
            if (hospedeDto == null)
                return new BaseResponse { StatusCode = StatusCodes.Status400BadRequest, Mensagem = "Não foi possível obter informações sobre o hóspede informado." };

            var reservasDto = await _reservasRepository.ObterReservas(query.HospedeId, query.Inativa);
            if (reservasDto == null)
                return new BaseResponse { StatusCode = StatusCodes.Status404NotFound, Mensagem = "Nenhuma reserva foi encontrada." };

            var acompanhanteDto = await _acompanhantesRepository.ObterAcompanhantes(query.HospedeId);

            var hospede = _mapper.Map<Hospede>(hospedeDto);
            var reservas = _mapper.Map<List<Reserva>>(reservasDto);
            var acompanhante = _mapper.Map<List<Acompanhante>>(acompanhanteDto);

            foreach(var reserva in reservas)
            {
                reserva.Acompanhantes = new List<Acompanhante>();
                reserva.Acompanhantes.AddRange(acompanhante.Where(x => x.ReservaId == reserva.ReservaId));           
            }

            var result = new ObterReservasResponse { StatusCode = StatusCodes.Status200OK, Mensagem = "Reservas retornadas com sucesso.", Hospede = hospede, Reservas = reservas };

            return result;
        }
    }
}
