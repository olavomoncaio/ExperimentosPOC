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
            _request.HospedeId = 123;
            var result = _validatorBody.Validate(_request);
            result.IsValid.Should().BeTrue();
        }

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(0)]
        public void ObterReservasRequestValidator_QuandoHospedeIdForInvalido_DeveRetornarSucesso(int hospedeId)
        {
            _request.HospedeId = hospedeId;
            var result = _validatorBody.Validate(_request);
            result.IsValid.Should().BeFalse();
        }
    }
}
