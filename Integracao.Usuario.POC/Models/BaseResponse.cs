using Newtonsoft.Json;

namespace Integracao.Usuario.POC.Models
{
    public class BaseResponse
    {
        [JsonIgnore]
        public int StatusCode { get; set; }

        public string Mensagem { get; set; }
    }
}
