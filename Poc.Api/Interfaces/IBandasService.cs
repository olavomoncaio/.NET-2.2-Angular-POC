using Poc.Api.Models;
using System.Threading.Tasks;

namespace Poc.Api.Interfaces
{
    public interface IBandasService
    {
        Task<BaseResponse> ListarBandas(BaseRequest route);
    }
}
