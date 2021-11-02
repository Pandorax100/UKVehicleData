using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class TechnicalDetails
    {
        [JsonPropertyName("Dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonPropertyName("Safety")]
        public Safety Safety { get; set; }

        [JsonPropertyName("General")]
        public General General { get; set; }

        [JsonPropertyName("Performance")]
        public Performance Performance { get; set; }

        [JsonPropertyName("Consumption")]
        public Consumption Consumption { get; set; }
    }
}
