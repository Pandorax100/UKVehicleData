using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class ElectricVehicleBattery
    {
        [JsonPropertyName("Capacity")]
        public object Capacity { get; set; }

        [JsonPropertyName("ChargePort")]
        public object ChargePort { get; set; }

        [JsonPropertyName("ChargeTime")]
        public object ChargeTime { get; set; }

        [JsonPropertyName("Type")]
        public object Type { get; set; }
    }
}
