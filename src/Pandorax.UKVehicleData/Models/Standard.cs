using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Standard
    {
        /// <summary>
        /// Standard six month VED rate.  Standard rate applies when no special rate, such as the
        /// 'first year' rate takes precidence.
        /// </summary>
        [JsonPropertyName("SixMonth")]
        public double? SixMonth { get; set; }

        /// <summary>
        /// Standard twelve month VED rate.  Standard rate applies when no special rate, such as the
        /// 'first year' rate takes precidence.
        /// </summary>
        [JsonPropertyName("TwelveMonth")]
        public double? TwelveMonth { get; set; }
    }
}
