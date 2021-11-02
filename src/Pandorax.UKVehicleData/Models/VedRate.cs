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
        public Standard Standard { get; set; }
    }
}
