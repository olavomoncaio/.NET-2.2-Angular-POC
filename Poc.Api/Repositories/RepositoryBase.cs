using Microsoft.Extensions.Configuration;

namespace Poc.Api.Repositories
{
    public class RepositoryBase
    {
        private readonly IConfiguration _configuration;

        public RepositoryBase(IConfiguration configuration) => _configuration = configuration;

        protected string ObterConexao
        {
            get { return _configuration.GetConnectionString("Bandas"); }
        }
    }
}
