using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Acceleration
    {
        /// <summary>
        /// The time, in seconds, taken by the vehicle to accelerate from 0 to 100 Kilometres per
        /// hour.
        /// </summary>
        [JsonPropertyName("Kph")]
        public double? Kph { get; set; }

        /// <summary>
        /// The time, in seconds, taken by the vehicle to accelerate from 0 to 60 Miles per Hour.
        /// </summary>
        [JsonPropertyName("Mph")]
        public double? Mph { get; set; }

        /// <summary>
        /// The time, in seconds, taken by the vehicle to accelerate from 0 to 100 Kilometres per
        /// hour.
        /// </summary>
        [JsonPropertyName("ZeroTo100Kph")]
        public double? ZeroTo100Kph { get; set; }

        /// <summary>
        /// The time, in seconds, taken by the vehicle to accelerate from 0 to 60 Miles per Hour.
        /// </summary>
        [JsonPropertyName("ZeroTo60Mph")]
        public double? ZeroTo60Mph { get; set; }
    }
}
