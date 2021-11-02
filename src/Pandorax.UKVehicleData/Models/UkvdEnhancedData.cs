using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class UkvdEnhancedData
    {
        [JsonPropertyName("ElectricVehicleData")]
        public object ElectricVehicleData { get; set; }

        [JsonPropertyName("Identification")]
        public Identification Identification { get; set; }
    }
}
