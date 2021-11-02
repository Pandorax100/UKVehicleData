using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Torque
    {
        /// <summary>
        /// Maximum torque of the engine as reported by the manufacturer in foot pounds.
        /// </summary>
        [JsonPropertyName("FtLb")]
        public double? FtLb { get; set; }

        /// <summary>
        /// Maximum torque of the engine as reported by the manufacturer in Newton Metres.
        /// </summary>
        [JsonPropertyName("Nm")]
        public double? Nm { get; set; }

        /// <summary>
        /// Engine speed in revolutions per minute at which the maximum torque occurs.
        /// </summary>
        [JsonPropertyName("Rpm")]
        public double? Rpm { get; set; }
    }
}
