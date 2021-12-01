using System;
using System.Text.Json.Serialization;
using Pandorax.UKVehicleData.JsonConverters;

namespace Pandorax.UKVehicleData.Models
{
    public class VehicleRegistration
    {
        /// <summary>
        /// This flag is set to True when a certificate of destruction has been issued for the
        /// vehicle.
        /// </summary>
        [JsonPropertyName("CertificateOfDestructionIssued")]
        public bool? CertificateOfDestructionIssued { get; set; }

        /// <summary>
        /// CO2 emissions figure for vehicle.
        /// </summary>
        [JsonPropertyName("Co2Emissions")]
        public double? Co2Emissions { get; set; }

        /// <summary>
        /// The current colour of the vehicle.
        /// </summary>
        [JsonPropertyName("Colour")]
        public string Colour { get; set; }

        /// <summary>
        /// The date that the vehicle was exported.  Only present if the vehicle has been exported.
        /// </summary>
        [JsonPropertyName("DateExported")]
        public string DateExported { get; set; }

        /// <summary>
        /// Date when the vehicle was first registered.  This may be the before the date the vehicle
        /// was first registered in the UK.
        /// </summary>
        [JsonPropertyName("DateFirstRegistered")]
        public DateTime? DateFirstRegistered { get; set; }

        /// <summary>
        /// Date when the vehicle was first registered in the UK with the DVLA.
        /// </summary>
        [JsonPropertyName("DateFirstRegisteredUk")]
        public DateTime? DateFirstRegisteredUk { get; set; }

        /// <summary>
        /// Date of the last update to the vehicle's core registration description details.
        /// </summary>
        [JsonPropertyName("DateOfLastUpdate")]
        public DateTime? DateOfLastUpdate { get; set; }

        /// <summary>
        /// The date that the vehicle was scrapped.  Only present if the vehicle has been scrapped.
        /// </summary>
        [JsonPropertyName("DateScrapped")]
        public string DateScrapped { get; set; }

        /// <summary>
        /// DVLA door plan code for this vehicle.
        /// </summary>
        [JsonPropertyName("DoorPlan")]
        public string DoorPlan { get; set; }

        /// <summary>
        /// Door plan description for this vehicle.
        /// </summary>
        [JsonPropertyName("DoorPlanLiteral")]
        public string DoorPlanLiteral { get; set; }

        /// <summary>
        /// The vehicle's registered engine capacity measured in c.c.
        /// </summary>
        [JsonPropertyName("EngineCapacity")]
        public string EngineCapacity { get; set; }

        /// <summary>
        /// The vehicle's engine number.
        /// </summary>
        [JsonPropertyName("EngineNumber")]
        public string EngineNumber { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the vehicle has been exported.
        /// </summary>
        [JsonPropertyName("Exported")]
        public bool? Exported { get; set; }

        /// <summary>
        /// Fuel type used by the vehicle.
        /// </summary>
        [JsonPropertyName("FuelType")]
        public string FuelType { get; set; }

        /// <summary>
        /// Number of gears (forward driving gear ratios) in the vehicle's transmission.
        /// </summary>
        [JsonPropertyName("GearCount")]
        public int? GearCount { get; set; }

        /// <summary>
        /// Vehicle gross weight.  For commercial vehicles only.
        /// </summary>
        [JsonPropertyName("GrossWeight")]
        public double? GrossWeight { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the vehicle has been imported.
        /// </summary>
        [JsonPropertyName("Imported")]
        public bool? Imported { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the vehicle has been imported from outside the EU.
        /// </summary>
        [JsonPropertyName("ImportNonEu")]
        public bool? ImportNonEu { get; set; }

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

        /// <summary>
        /// Maximum permissible weight for the vehicle.
        /// </summary>
        [JsonPropertyName("MaxPermissibleMass")]
        public double? MaxPermissibleMass { get; set; }

        /// <summary>
        /// Vehicle model.
        /// </summary>
        [JsonPropertyName("Model")]
        public string Model { get; set; }

        /// <summary>
        /// MVRIS (Motor Vehicle Registration Information System) make code for this vehicle.
        /// </summary>
        [JsonPropertyName("MvrisMakeCode")]
        public string MvrisMakeCode { get; set; }

        /// <summary>
        /// MVRIS (Motor Vehicle Registration Information System) model code for this vehicle.
        /// </summary>
        [JsonPropertyName("MvrisModelCode")]
        public string MvrisModelCode { get; set; }

        /// <summary>
        /// PreviousVrmGb is supplied by the DVLNI prior to 2009. It is the VRM that was on this
        /// vehicle prior to it being registered with the DVLNI, but only if the vehicle was
        /// registered with the DVLA immediately prior to being registered with the DVLA.
        /// </summary>
        [JsonPropertyName("PreviousVrmGb")]
        public string PreviousVrmGb { get; set; }

        /// <summary>
        /// PreviousVrmNi is supplied by the DVLA prior to 2009.  It is the VRM that was on this
        /// vehicle prior to it being registered with the DVLA, but only if the vehicle was
        /// registered with the DVLNI immediately prior to being registered with the DVLA.
        /// </summary>
        [JsonPropertyName("PreviousVrmNi")]
        public string PreviousVrmNi { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the vehicle has been scrapped.
        /// </summary>
        [JsonPropertyName("Scrapped")]
        public bool? Scrapped { get; set; }

        /// <summary>
        /// Seating capacity of the vehicle.
        /// </summary>
        [JsonPropertyName("SeatingCapacity")]
        public int? SeatingCapacity { get; set; }

        /// <summary>
        /// Description of transmission.
        /// </summary>
        [JsonPropertyName("Transmission")]
        public string Transmission { get; set; }

        /// <summary>
        /// Code indicating type of transmission used in the vehicle.
        /// </summary>
        [JsonPropertyName("TransmissionCode")]
        public string TransmissionCode { get; set; }

        /// <summary>
        /// Type of transmission used in this vehicle.
        /// </summary>
        [JsonPropertyName("TransmissionType")]
        public string TransmissionType { get; set; }

        /// <summary>
        /// Classification of the general type of this vehicle (e.g. Motorcycle, Car, LCV, HCV, PCV
        /// or Other).
        /// </summary>
        [JsonPropertyName("VehicleClass")]
        public string VehicleClass { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the vehicle was used before the date of first
        /// registration in the UK.
        /// </summary>
        [JsonPropertyName("VehicleUsedBeforeFirstRegistration")]
        public bool? VehicleUsedBeforeFirstRegistration { get; set; }

        /// <summary>
        /// The vehicle's unique Vehicle Identification Number.
        /// </summary>
        [JsonPropertyName("Vin")]
        public string Vin { get; set; }

        /// <summary>
        /// Only present if optional key_vin was passed in to query.  'Partial match' indicates a
        /// partial match, 'FullMatch' indicates a full match, null indicates no match.
        /// </summary>
        [JsonPropertyName("VinConfirmationFlag")]
        public string VinConfirmationFlag { get; set; }

        /// <summary>
        /// The last 5 characters of the Vehicle Identification Number.
        /// </summary>
        [JsonPropertyName("VinLast5")]
        public string VinLast5 { get; set; }

        /// <summary>
        /// The DVLA assigned Vehicle Registration Mark for this vehicle.
        /// </summary>
        [JsonPropertyName("Vrm")]
        public string Vrm { get; set; }

        /// <summary>
        /// Vehicle wheel plan.  For commercial vehicles only.
        /// </summary>
        [JsonPropertyName("WheelPlan")]
        public string WheelPlan { get; set; }

        /// <summary>
        /// Year and month when the vehicle was first registered.  This may be the before the date
        /// the vehicle was first registered in the UK.
        /// </summary>
        [JsonPropertyName("YearMonthFirstRegistered")]
        [JsonConverter(typeof(YearMonthDateConverter))]
        public DateTime? YearMonthFirstRegistered { get; set; }

        /// <summary>
        /// The year in which the vehicle was manufactured.
        /// </summary>
        [JsonPropertyName("YearOfManufacture")]
        public string YearOfManufacture { get; set; }
    }
}
