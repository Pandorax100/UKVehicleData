using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class DataItems
    {
        [JsonPropertyName("UkvdEnhancedData")]
        public UkvdEnhancedData UkvdEnhancedData { get; set; }

        [JsonPropertyName("TechnicalDetails")]
        public TechnicalDetails TechnicalDetails { get; set; }

        [JsonPropertyName("ClassificationDetails")]
        public ClassificationDetails ClassificationDetails { get; set; }

        [JsonPropertyName("VehicleStatus")]
        public VehicleStatus VehicleStatus { get; set; }

        [JsonPropertyName("VehicleHistory")]
        public VehicleHistory VehicleHistory { get; set; }

        [JsonPropertyName("VehicleRegistration")]
        public VehicleRegistration VehicleRegistration { get; set; }

        [JsonPropertyName("SmmtDetails")]
        public SmmtDetails SmmtDetails { get; set; }
    }
}
