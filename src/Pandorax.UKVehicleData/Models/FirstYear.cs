using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class FirstYear
    {
        /// <summary>
        /// Six month VED rate for first year after a new vehicle is registered.
        /// </summary>
        [JsonPropertyName("SixMonth")]
        public double? SixMonth { get; set; }

        /// <summary>
        /// Twelve month VED rate for first year after a new vehicle is registered.
        /// </summary>
        [JsonPropertyName("TwelveMonth")]
        public double? TwelveMonth { get; set; }
    }
}
