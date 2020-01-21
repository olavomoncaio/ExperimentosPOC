using AutoMapper;
using Integracao.Usuario.POC.Mapper;
using Xunit;

namespace Integracao.Usuario.POC.Test.Mapper
{
    public class ReservasProfileTest
    {
        private readonly MapperConfiguration config;

        public ReservasProfileTest()
        {
            config = new MapperConfiguration(cfg => cfg.AddProfile<ReservasProfile>());
        }

        [Fact]
        public void MapperConfiguration_QuandoMontarOMapeamento_DeveFuncionarCorretamente()
        {
            config.AssertConfigurationIsValid();
        }
    }
}
