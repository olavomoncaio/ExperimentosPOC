using FluentAssertions;
using Integracao.Usuario.POC.Dto;
using Integracao.Usuario.POC.Models;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace Integracao.Usuario.POC.Test.Services
{
    public class ReservasServiceTest : BaseServiceTest
    {
        public ReservasServiceTest() : base()
        {
        }

        [Fact]
        public async void ListarReservas_QuandoNaoForPossivelObterHospede_DeveRetornar400BadRequest()
        {
            //Arrange
            _hospedesRepository.ObterHospede(_request.HospedeId).Returns(default(HospedeDto));

            //Act
            var result = await _service.ListarReservas(_request);

            //Assert
            result.StatusCode.Should().Be(400);
        }

        [Fact]
        public async void ListarReservas_QuandoNenhumaReservaForEncontrada_DeveRetornar404NotFound()
        {
            //Arrange
            _hospedesRepository.ObterHospede(_request.HospedeId).Returns(_hospedeDto);
            _reservasRepository.ObterReservas(_request.HospedeId, Arg.Any<bool>()).Returns(default(IEnumerable<ReservaDto>));

            //Act
            var result = await _service.ListarReservas(_request);

            //Assert
            result.StatusCode.Should().Be(404);
        }

        [Fact]
        public async void ListarReservas_QuandoTudoDerCerto_DeveRetornar200OK()
        {
            //Arrange
            _hospedesRepository.ObterHospede(_request.HospedeId).Returns(_hospedeDto);
            _reservasRepository.ObterReservas(_request.HospedeId, Arg.Any<bool>()).Returns(_reservaDto);
            _acompanhantesRepository.ObterAcompanhantes(_request.HospedeId).Returns(_acompanhanteDto);
            _mapper.Map<Hospede>(_hospedeDto).Returns(_hospede);
            _mapper.Map<List<Reserva>>(_reservaDto).Returns(_reserva);
            _mapper.Map<List<Acompanhante>>(_acompanhanteDto).Returns(_acompanhante);

            //Act
            var result = await _service.ListarReservas(_request);

            //Assert
            result.StatusCode.Should().Be(200);
        }
    }
}
