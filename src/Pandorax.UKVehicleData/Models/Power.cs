using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Power
    {
        /// <summary>
        /// Maximum power expressed in brake horse power.
        /// </summary>
        [JsonPropertyName("Bhp")]
        public double Bhp { get; set; }

        /// <summary>
        /// Engine speed in revolutions per minute at which the maximum power occurs.
        /// </summary>
        [JsonPropertyName("Rpm")]
        public double Rpm { get; set; }

        /// <summary>
        /// Maximum power expressed in kilowatts.
        /// </summary>
        [JsonPropertyName("Kw")]
        public double Kw { get; set; }
    }
}
