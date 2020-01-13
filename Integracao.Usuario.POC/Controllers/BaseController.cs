using Integracao.Usuario.POC.Interfaces;

namespace Integracao.Usuario.POC.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
        private readonly ILogger _logger;
        protected readonly IReservaService _service;
        private readonly string MensagemErroPadrao = "Ocorreu um erro ao processar a solicitação. Por favor, tente novamente mais tarde.";

        protected BaseController(ILogger logger, IReservaService service)
        {
            _logger = logger;
            _service = service;
        }

        protected async Task<IActionResult> TratarResultadoAsync(Func<Task<IActionResult>> service)
        { 
            try
            {
                return await service();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message} {ex.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError, new { Mensagem = MensagemErroPadrao });
            }
        }
    }
}
