using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Ukvd
    {
        [JsonPropertyName("IsElectricVehicle")]
        public bool IsElectricVehicle { get; set; }

        [JsonPropertyName("VrmFormat")]
        public VrmFormat VrmFormat { get; set; }
    }
}
