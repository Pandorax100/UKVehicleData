using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class General
    {
        [JsonPropertyName("Engine")]
        public Engine Engine { get; set; }

        [JsonPropertyName("PowerDelivery")]
        public object PowerDelivery { get; set; }

        [JsonPropertyName("TypeApprovalCategory")]
        public object TypeApprovalCategory { get; set; }

        [JsonPropertyName("ElectricVehicleBattery")]
        public ElectricVehicleBattery ElectricVehicleBattery { get; set; }

        [JsonPropertyName("SeriesDescription")]
        public string SeriesDescription { get; set; }

        [JsonPropertyName("DriverPosition")]
        public string DriverPosition { get; set; }

        [JsonPropertyName("DrivingAxle")]
        public string DrivingAxle { get; set; }

        [JsonPropertyName("DataVersionNumber")]
        public object DataVersionNumber { get; set; }

        [JsonPropertyName("EuroStatus")]
        public string EuroStatus { get; set; }

        [JsonPropertyName("IsLimitedEdition")]
        public bool IsLimitedEdition { get; set; }
    }
}
