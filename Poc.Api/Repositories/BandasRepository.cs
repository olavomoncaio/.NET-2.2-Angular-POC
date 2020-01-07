using Microsoft.Extensions.Configuration;

namespace Poc.Api.Repositories
{
    public class BandasRepository : RepositoryBase
    {
        public BandasRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
