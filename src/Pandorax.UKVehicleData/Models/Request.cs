using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Request
    {
        [JsonPropertyName("ApiKeyId")]
        public string ApiKeyId { get; set; }

        [JsonPropertyName("PackageId")]
        public string PackageId { get; set; }

        [JsonPropertyName("PackageVersion")]
        public double? PackageVersion { get; set; }

        [JsonPropertyName("ResponseVersion")]
        public double? ResponseVersion { get; set; }
    }
}
