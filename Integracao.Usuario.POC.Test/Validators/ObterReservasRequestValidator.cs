using AutoFixture;
using FluentAssertions;
using Integracao.Usuario.POC.Models;
using Integracao.Usuario.POC.Utils.Validators;
using Xunit;

namespace Integracao.Usuario.POC.Test.Validators
{
    public class ObterReservasRequestValidatorTest
    {
        private readonly ObterReservasRequestValidator _validatorBody;
        private readonly ObterReservasRequest _request;
        private readonly Fixture fixture;

        public ObterReservasRequestValidatorTest()
        {
            fixture = new Fixture();
            _validatorBody = new ObterReservasRequestValidator();
            _request = fixture.Create<ObterReservasRequest>();
        }

        [Fact]
        public void ObterReservasRequestValidator_QuandoTodosOsDadosEstiveremCorretos_DeveRetornarSucesso()
        {
            _request.Documento = "12345678901";
            var result = _validatorBody.Validate(_request);
            result.IsValid.Should().BeTrue();
        }


        [Theory]
        [InlineData("1111111111111111")]
        [InlineData("111111")]
        [InlineData("")]
        public void ObterReservasRequestValidator_QuandoDocumentoForVazioOuInvalido_DeveRetornarErro(string documento)
        {
            _request.Documento = documento;
            var result = _validatorBody.Validate(_request);
            result.IsValid.Should().BeFalse();
        }
    }
}
