using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Response
    {
        [JsonPropertyName("DataItems")]
        public DataItems DataItems { get; set; }

        [JsonPropertyName("StatusCode")]
        public string StatusCode { get; set; }

        [JsonPropertyName("StatusMessage")]
        public string StatusMessage { get; set; }
    }
}
