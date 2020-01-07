using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Poc.Api.Interfaces;
using System;
using System.Threading.Tasks;

namespace Poc.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
        private readonly ILogger _logger;
        public readonly IBandasService _service;
        private readonly string MensagemErroPadrao = "Ocorreu um erro ao processar solicitação. Por favor, tente novamente mais tarde.";

        protected BaseController(ILogger logger, IBandasService service)
        {
            _logger = logger;
            _service = service;
        }

        protected async Task<IActionResult> TratarResultadoAsync(Func<Task<IActionResult>> servico)
        {
            try
            {
                return await servico();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message} {ex.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError, new { Mensagem = MensagemErroPadrao });
            }
        }
    }
}
