using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class UkvdEnhancedData
    {
        [JsonPropertyName("ElectricVehicleData")]
        public Dictionary<string, object> ElectricVehicleData { get; set; }

        [JsonPropertyName("Identification")]
        public Identification Identification { get; set; }
    }
}
