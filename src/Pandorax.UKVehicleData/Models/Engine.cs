using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Engine
    {
        [JsonPropertyName("FuelCatalyst")]
        public string FuelCatalyst { get; set; }

        [JsonPropertyName("Stroke")]
        public object Stroke { get; set; }

        [JsonPropertyName("PrimaryFuelFlag")]
        public object PrimaryFuelFlag { get; set; }

        [JsonPropertyName("ValvesPerCylinder")]
        public long ValvesPerCylinder { get; set; }

        [JsonPropertyName("Aspiration")]
        public string Aspiration { get; set; }

        [JsonPropertyName("FuelSystem")]
        public string FuelSystem { get; set; }

        [JsonPropertyName("NumberOfCylinders")]
        public long NumberOfCylinders { get; set; }

        [JsonPropertyName("CylinderArrangement")]
        public string CylinderArrangement { get; set; }

        [JsonPropertyName("ValveGear")]
        public string ValveGear { get; set; }

        [JsonPropertyName("Location")]
        public object Location { get; set; }

        [JsonPropertyName("Description")]
        public object Description { get; set; }

        [JsonPropertyName("Bore")]
        public object Bore { get; set; }

        [JsonPropertyName("Make")]
        public object Make { get; set; }

        [JsonPropertyName("FuelDelivery")]
        public string FuelDelivery { get; set; }
    }
}
