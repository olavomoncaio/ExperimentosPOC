using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Http;

namespace Integracao.Usuario.POC.Test.Controllers
{
    public class ReservasControllerTest : BaseControllerTest
    {
        public ReservasControllerTest() : base()
        {
        }

        [Fact]
        public async void Listar_QuandoListarCorretamento_DeveRetornar200OK()
        {
            _service.ListarReservas(_request).Returns(_response);
            _response.StatusCode = StatusCodes.Status200OK;

            var resultado = (ObjectResult)await _controller.Listar(_request);

            resultado.StatusCode.Should().Be(200);
        }
    }
}
