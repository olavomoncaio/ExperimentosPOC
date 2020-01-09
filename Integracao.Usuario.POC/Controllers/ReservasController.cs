using Integracao.Usuario.POC.Interfaces;
using Integracao.Usuario.POC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Integracao.Usuario.POC.Controllers
{
    [Route("[controller]")]
    public class ReservasController : BaseController
    {
        public ReservasController(ILogger<ReservasController> logger, IReservaService service) : base(logger, service)
        {
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterArquivos([FromBody] ObterReservasRequest query)
        {
            return await TratarResultadoAsync(async () =>
            {
                var resultado = await _service.Listar(query);

                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            });
        }
    }
}
