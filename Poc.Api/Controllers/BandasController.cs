using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Poc.Api.Interfaces;
using Poc.Api.Models;
using System.Threading.Tasks;

namespace Poc.Api.Controllers
{
    [Route("[controller]")]
    public class BandasController : BaseController
    {
        public BandasController(ILogger<BandasController> logger, IBandasService service) : base(logger, service)
        {
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListarBandas([FromRoute] BaseRequest route)
        {
            return await TratarResultadoAsync(async () =>
            {
                var resultado = await _service.ListarBandas(route);

                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            });
        }
    }
}

