using AutoFixture;
using Integracao.Usuario.POC.Controllers;
using Integracao.Usuario.POC.Interfaces;
using Integracao.Usuario.POC.Models;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace Integracao.Usuario.POC.Test.Controllers
{
    public class BaseControllerTest
    {
        protected readonly Fixture fixture;
        protected readonly IReservaService _service;
        protected readonly ObterReservasRequest _request;
        protected readonly ObterReservasResponse _response;
        protected readonly ReservasController _controller;
        protected readonly ILogger<ReservasController> _logger;

        public BaseControllerTest()
        {
            fixture = new Fixture();
            _service = Substitute.For<IReservaService>();
            _request = fixture.Create<ObterReservasRequest>();
            _response = fixture.Create<ObterReservasResponse>();
            _controller = new ReservasController(_logger, _service);
        }
    }
}
