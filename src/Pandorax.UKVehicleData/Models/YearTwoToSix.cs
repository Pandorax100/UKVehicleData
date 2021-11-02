using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class YearTwoToSix
    {
        /// <summary>
        /// Six month VED rate for the second to sixth years after a new vehicle with Â£40,000 or
        /// greater list price (including options) is registered.
        /// </summary>
        [JsonPropertyName("SixMonth")]
        public double? SixMonth { get; set; }

        /// <summary>
        /// Twelve month VED rate for the second to sixth years after a new vehicle with Â£40,000 or
        /// greater list price (including options) is registered.
        /// </summary>
        [JsonPropertyName("TwelveMonth")]
        public double? TwelveMonth { get; set; }
    }
}
