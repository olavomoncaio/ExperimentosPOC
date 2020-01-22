using AutoFixture;
using AutoMapper;
using Integracao.Usuario.POC.Dto;
using Integracao.Usuario.POC.Interfaces;
using Integracao.Usuario.POC.Models;
using Integracao.Usuario.POC.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NSubstitute;
using System.Collections.Generic;

namespace Integracao.Usuario.POC.Test.Services
{
    public class BaseServiceTest
    {
        protected readonly ReservasService _service;
        protected readonly Fixture fixture;
        protected readonly IHospedesRepository _hospedesRepository;
        protected readonly IReservasRepository _reservasRepository;
        protected readonly IAcompanhantesRepository _acompanhantesRepository;
        protected readonly ObterReservasRequest _request;
        protected readonly ILogger<ReservasService> _logger;
        protected readonly IConfiguration _configuration;
        protected readonly IMapper _mapper;
        protected readonly HospedeDto _hospedeDto;
        protected readonly IEnumerable<ReservaDto> _reservaDto;
        protected readonly IEnumerable<AcompanhanteDto> _acompanhanteDto;
        protected readonly Hospede _hospede;
        protected readonly List<Acompanhante> _acompanhante;
        protected readonly List<Reserva> _reserva;

        public BaseServiceTest()
        {
            fixture = new Fixture();
            _request = fixture.Create<ObterReservasRequest>();
            _hospedesRepository = Substitute.For<IHospedesRepository>();
            _reservasRepository = Substitute.For<IReservasRepository>();
            _acompanhantesRepository = Substitute.For<IAcompanhantesRepository>();
            _logger = Substitute.For<ILogger<ReservasService>>();
            _configuration = Substitute.For<IConfiguration>();
            _mapper = Substitute.For<IMapper>();
            _hospedeDto = fixture.Create<HospedeDto>();
            _hospede = fixture.Create<Hospede>();
            _acompanhante = fixture.Create<List<Acompanhante>>();
            _reserva = fixture.Create<List<Reserva>>();
            _reservaDto = fixture.Create<IEnumerable<ReservaDto>>();
            _acompanhanteDto = fixture.Create<IEnumerable<AcompanhanteDto>>();
            _service = new ReservasService(_logger, _configuration, _mapper, _reservasRepository, _hospedesRepository, _acompanhantesRepository);
        }
    }
}
