using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class General
    {
        /// <summary>
        /// Version number for this data.
        /// </summary>
        [JsonPropertyName("DataVersionNumber")]
        public double? DataVersionNumber { get; set; }

        /// <summary>
        /// Driver side position within vehicle.
        /// </summary>
        [JsonPropertyName("DriverPosition")]
        public string DriverPosition { get; set; }

        /// <summary>
        /// Location of powered axle/s.
        /// </summary>
        [JsonPropertyName("DrivingAxle")]
        public string DrivingAxle { get; set; }

        [JsonPropertyName("ElectricVehicleBattery")]
        public ElectricVehicleBattery ElectricVehicleBattery { get; set; }

        [JsonPropertyName("Engine")]
        public Engine Engine { get; set; }

        /// <summary>
        /// The highest European engine standard which the engine meets (e.g. '3','4','5'). Recorded
        /// on V5C document.
        /// </summary>
        [JsonPropertyName("EuroStatus")]
        public string EuroStatus { get; set; }

        /// <summary>
        /// Indicates whether or not the vehicle is part of a limited edition.
        /// </summary>
        [JsonPropertyName("IsLimitedEdition")]
        public bool? IsLimitedEdition { get; set; }

        /// <summary>
        /// Descriptive field to indicate Hybrid or non-hybrid powertrains (Normal).
        /// </summary>
        [JsonPropertyName("PowerDelivery")]
        public string PowerDelivery { get; set; }

        /// <summary>
        /// Vehicle series description.
        /// </summary>
        [JsonPropertyName("SeriesDescription")]
        public string SeriesDescription { get; set; }

        /// <summary>
        /// European Vehicle Type - e.g  Passenger Car = 'M1',
        /// </summary>
        [JsonPropertyName("TypeApprovalCategory")]
        public string TypeApprovalCategory { get; set; }
    }
}
