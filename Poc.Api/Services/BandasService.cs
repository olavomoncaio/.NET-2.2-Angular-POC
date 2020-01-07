using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Poc.Api.Interfaces;
using Poc.Api.Models;
using System.Threading.Tasks;

namespace Poc.Api.Services
{
    public class BandasService : IBandasService
    {
        protected readonly IConfiguration _configuration;
        protected readonly ILogger<BandasService> _log;

        public BandasService(IConfiguration configuration, ILogger<BandasService> log)
        {
            _configuration = configuration;
            _log = log;
        }

        public async Task<BaseResponse> ListarBandas(BaseRequest route)
        {
            var result = new BandasResponse() { StatusCode = StatusCodes.Status200OK };

            return result;
        }
    }
}
