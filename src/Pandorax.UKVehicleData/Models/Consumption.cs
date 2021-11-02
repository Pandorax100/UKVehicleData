using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Consumption
    {
        [JsonPropertyName("ExtraUrban")]
        public Combined ExtraUrban { get; set; }

        [JsonPropertyName("UrbanCold")]
        public Combined UrbanCold { get; set; }

        [JsonPropertyName("Combined")]
        public Combined Combined { get; set; }
    }
}
