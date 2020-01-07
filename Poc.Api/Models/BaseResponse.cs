using Newtonsoft.Json;

namespace Poc.Api.Models
{
    public class BaseResponse
    {
        [JsonIgnore]
        public int StatusCode { get; set; }

        public string Mensagem { get; set; }
    }
}
