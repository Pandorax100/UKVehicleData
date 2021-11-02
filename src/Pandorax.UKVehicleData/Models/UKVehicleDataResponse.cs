using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class UKVehicleDataResponse
    {
        [JsonPropertyName("Request")]
        public Request Request { get; set; }

        [JsonPropertyName("Response")]
        public Response Response { get; set; }
    }
}
