using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Performance
    {
        [JsonPropertyName("Acceleration")]
        public Acceleration Acceleration { get; set; }

        /// <summary>
        /// Exhaust emission of carbon dioxide, measured as part of the type approval process,
        /// expressed in grams per kilometre.
        /// </summary>
        [JsonPropertyName("Co2")]
        public double? Co2 { get; set; }

        /// <summary>
        /// Version Number for this data.
        /// </summary>
        [JsonPropertyName("DataVersionNumber")]
        public double? DataVersionNumber { get; set; }

        [JsonPropertyName("MaxSpeed")]
        public MaxSpeed MaxSpeed { get; set; }

        /// <summary>
        /// Vehicle noise emissions level.
        /// </summary>
        [JsonPropertyName("NoiseLevel")]
        public double? NoiseLevel { get; set; }

        /// <summary>
        /// Vehicle particulate emissions.
        /// </summary>
        [JsonPropertyName("Particles")]
        public double? Particles { get; set; }

        [JsonPropertyName("Power")]
        public Power Power { get; set; }

        [JsonPropertyName("Torque")]
        public Torque Torque { get; set; }
    }
}
