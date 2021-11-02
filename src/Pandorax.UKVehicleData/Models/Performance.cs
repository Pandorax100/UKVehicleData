using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Performance
    {
        [JsonPropertyName("Torque")]
        public Torque Torque { get; set; }

        /// <summary>
        /// Vehicle noise emissions level.
        /// </summary>
        [JsonPropertyName("NoiseLevel")]
        public double NoiseLevel { get; set; }

        [JsonPropertyName("DataVersionNumber")]
        public double DataVersionNumber { get; set; }

        [JsonPropertyName("Power")]
        public Power Power { get; set; }

        [JsonPropertyName("MaxSpeed")]
        public MaxSpeed MaxSpeed { get; set; }

        [JsonPropertyName("Co2")]
        public long Co2 { get; set; }

        [JsonPropertyName("Particles")]
        public object Particles { get; set; }

        [JsonPropertyName("Acceleration")]
        public Dictionary<string, double?> Acceleration { get; set; }
    }
}
