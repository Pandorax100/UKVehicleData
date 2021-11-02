using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Consumption
    {
        [JsonPropertyName("Combined")]
        public FuelConsumption Combined { get; set; }

        [JsonPropertyName("ExtraUrban")]
        public FuelConsumption ExtraUrban { get; set; }

        [JsonPropertyName("UrbanCold")]
        public FuelConsumption UrbanCold { get; set; }
    }
}
