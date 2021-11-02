using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class ElectricVehicleBattery
    {
        /// <summary>
        /// Capacity of Electric Vehicle Battery used.
        /// </summary>
        [JsonPropertyName("Capacity")]
        public string Capacity { get; set; }

        /// <summary>
        /// Type of charge port used to charge the Electric Vehicle Battery.
        /// </summary>
        [JsonPropertyName("ChargePort")]
        public string ChargePort { get; set; }

        /// <summary>
        /// Time required to charge Electric Vehicle Battery.
        /// </summary>
        [JsonPropertyName("ChargeTime")]
        public string ChargeTime { get; set; }

        /// <summary>
        /// Type of Electric Vehicle Battery used.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
