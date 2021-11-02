using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Ukvd
    {
        /// <summary>
        /// Indicates whether this is an electric vehicle.
        /// </summary>
        [JsonPropertyName("IsElectricVehicle")]
        public bool? IsElectricVehicle { get; set; }

        [JsonPropertyName("VrmFormat")]
        public VrmFormat VrmFormat { get; set; }
    }
}
