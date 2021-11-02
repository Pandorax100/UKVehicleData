using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class VehicleStatus
    {
        [JsonPropertyName("MotVed")]
        public MotVed MotVed { get; set; }
    }
}
