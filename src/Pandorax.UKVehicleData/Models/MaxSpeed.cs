using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class MaxSpeed
    {
        /// <summary>
        /// Maximum speed of the model variant as per the brochure in kilometres per hour.
        /// </summary>
        [JsonPropertyName("Kph")]
        public double? Kph { get; set; }

        /// <summary>
        /// Maximum speed of the model variant as per the brochure in miles per hour.
        /// </summary>
        [JsonPropertyName("Mph")]
        public double? Mph { get; set; }
    }
}
