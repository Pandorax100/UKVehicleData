using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class VrmFormat
    {
        [JsonPropertyName("IsGbGeneralFormat")]
        public bool IsGbGeneralFormat { get; set; }

        [JsonPropertyName("IsNiGeneralFormat")]
        public bool IsNiGeneralFormat { get; set; }
    }
}
