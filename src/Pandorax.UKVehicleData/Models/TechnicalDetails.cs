using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class TechnicalDetails
    {
        [JsonPropertyName("Consumption")]
        public Consumption Consumption { get; set; }

        [JsonPropertyName("Dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonPropertyName("General")]
        public General General { get; set; }

        [JsonPropertyName("Performance")]
        public Performance Performance { get; set; }

        [JsonPropertyName("Safety")]
        public Safety Safety { get; set; }
    }
}
