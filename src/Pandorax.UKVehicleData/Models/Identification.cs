using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Identification
    {
        /// <summary>
        /// Indicates whether this is an electric vehicle.
        /// </summary>
        [JsonPropertyName("IsElectricVehicle")]
        public bool IsElectricVehicle { get; set; }
    }
}
