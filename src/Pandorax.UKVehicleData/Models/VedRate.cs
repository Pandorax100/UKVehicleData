using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class VedRate
    {
        [JsonPropertyName("FirstYear")]
        public FirstYear FirstYear { get; set; }

        [JsonPropertyName("PremiumVehicle")]
        public PremiumVehicle PremiumVehicle { get; set; }

        [JsonPropertyName("Standard")]
        public FirstYear Standard { get; set; }
    }
}
