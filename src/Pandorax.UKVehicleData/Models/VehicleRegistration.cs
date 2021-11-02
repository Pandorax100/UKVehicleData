using System;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class VehicleRegistration
    {
        /// <summary>
        /// Date of the last update to the vehicle's core registration description details.
        /// </summary>
        [JsonPropertyName("DateOfLastUpdate")]
        public DateTimeOffset DateOfLastUpdate { get; set; }

        /// <summary>
        /// The current colour of the vehicle.
        /// </summary>
        [JsonPropertyName("Colour")]
        public string Colour { get; set; }

        [JsonPropertyName("VehicleClass")]
        public string VehicleClass { get; set; }

        /// <summary>
        /// This flag is set to True when a certificate of destruction has been issued for the vehicle.
        /// </summary>
        [JsonPropertyName("CertificateOfDestructionIssued")]
        public bool CertificateOfDestructionIssued { get; set; }

        /// <summary>
        /// The vehicle's engine number.
        /// </summary>
        [JsonPropertyName("EngineNumber")]
        public string EngineNumber { get; set; }

        /// <summary>
        /// The vehicle's registered engine capacity measured in c.c.
        /// </summary>
        [JsonPropertyName("EngineCapacity")]
        public long EngineCapacity { get; set; }

        [JsonPropertyName("TransmissionCode")]
        public object TransmissionCode { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the vehicle has been exported.
        /// </summary>
        [JsonPropertyName("Exported")]
        public bool Exported { get; set; }

        [JsonPropertyName("YearOfManufacture")]
        public long YearOfManufacture { get; set; }

        [JsonPropertyName("WheelPlan")]
        public string WheelPlan { get; set; }

        /// <summary>
        /// The date that the vehicle was exported. Only present if the vehicle has been exported.
        /// </summary>
        [JsonPropertyName("DateExported")]
        public DateTimeOffset? DateExported { get; set; }

        [JsonPropertyName("Scrapped")]
        public bool Scrapped { get; set; }

        [JsonPropertyName("Transmission")]
        public object Transmission { get; set; }

        /// <summary>
        /// Date when the vehicle was first registered in the UK with the DVLA.
        /// </summary>
        [JsonPropertyName("DateFirstRegisteredUk")]
        public DateTimeOffset DateFirstRegisteredUk { get; set; }

        [JsonPropertyName("Model")]
        public string Model { get; set; }

        /// <summary>
        /// Number of gears (forward driving gear ratios) in the vehicle's transmission.
        /// </summary>
        [JsonPropertyName("GearCount")]
        public long GearCount { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the vehicle has been imported from outside the EU.
        /// </summary>
        [JsonPropertyName("ImportNonEu")]
        public bool ImportNonEu { get; set; }

        [JsonPropertyName("PreviousVrmGb")]
        public object PreviousVrmGb { get; set; }

        /// <summary>
        /// Vehicle gross weight. For commercial vehicles only.
        /// </summary>
        [JsonPropertyName("GrossWeight")]
        public long GrossWeight { get; set; }

        /// <summary>
        /// Door plan description for this vehicle.
        /// </summary>
        [JsonPropertyName("DoorPlanLiteral")]
        public string DoorPlanLiteral { get; set; }

        /// <summary>
        /// MVRIS (Motor Vehicle Registration Information System) model code for this vehicle.
        /// </summary>
        [JsonPropertyName("MvrisModelCode")]
        public string MvrisModelCode { get; set; }

        [JsonPropertyName("Vin")]
        public string Vin { get; set; }

        [JsonPropertyName("Vrm")]
        public string Vrm { get; set; }

        /// <summary>
        /// Date when the vehicle was first registered. This may be the before the date the vehicle was first registered in the UK.
        /// </summary>
        [JsonPropertyName("DateFirstRegistered")]
        public DateTimeOffset DateFirstRegistered { get; set; }

        /// <summary>
        /// The date that the vehicle was scrapped.  Only present if the vehicle has been scrapped.
        /// </summary>
        [JsonPropertyName("DateScrapped")]
        public DateTimeOffset DateScrapped { get; set; }

        /// <summary>
        /// DVLA door plan code for this vehicle.
        /// </summary>
        [JsonPropertyName("DoorPlan")]
        public long DoorPlan { get; set; }

        [JsonPropertyName("YearMonthFirstRegistered")]
        public string YearMonthFirstRegistered { get; set; }

        [JsonPropertyName("VinLast5")]
        public long VinLast5 { get; set; }

        [JsonPropertyName("VehicleUsedBeforeFirstRegistration")]
        public bool VehicleUsedBeforeFirstRegistration { get; set; }

        /// <summary>
        /// Maximum permissible weight for the vehicle.
        /// </summary>
        [JsonPropertyName("MaxPermissibleMass")]
        public long MaxPermissibleMass { get; set; }

        /// <summary>
        /// Vehicle make.
        /// </summary>
        [JsonPropertyName("Make")]
        public string Make { get; set; }

        /// <summary>
        /// Vehicle make and model.
        /// </summary>
        [JsonPropertyName("MakeModel")]
        public string MakeModel { get; set; }

        [JsonPropertyName("TransmissionType")]
        public string TransmissionType { get; set; }

        [JsonPropertyName("SeatingCapacity")]
        public long SeatingCapacity { get; set; }

        /// <summary>
        /// Fuel type used by the vehicle.
        /// </summary>
        [JsonPropertyName("FuelType")]
        public string FuelType { get; set; }

        /// <summary>
        /// CO2 emissions figure for vehicle.
        /// </summary>
        [JsonPropertyName("Co2Emissions")]
        public long Co2Emissions { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the vehicle has been imported.
        /// </summary>
        [JsonPropertyName("Imported")]
        public bool Imported { get; set; }

        /// <summary>
        /// MVRIS (Motor Vehicle Registration Information System) make code for this vehicle.
        /// </summary>
        [JsonPropertyName("MvrisMakeCode")]
        public string MvrisMakeCode { get; set; }

        [JsonPropertyName("PreviousVrmNi")]
        public object PreviousVrmNi { get; set; }

        [JsonPropertyName("VinConfirmationFlag")]
        public object VinConfirmationFlag { get; set; }
    }
}
