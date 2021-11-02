using System;
using System.Text.Json.Serialization;
using Pandorax.UKVehicleData.JsonConverters;

namespace Pandorax.UKVehicleData.Models
{
    public class SmmtDetails
    {
        /// <summary>
        /// The style of the vehicle's body.  E.g. 'Estate', 'MPV', 'Saloon', etc.
        /// </summary>
        [JsonPropertyName("BodyStyle")]
        public string BodyStyle { get; set; }

        /// <summary>
        /// Refers to HGVs only. Describes if any cabin is available to sleep in.
        /// </summary>
        [JsonPropertyName("CabType")]
        public string CabType { get; set; }

        /// <summary>
        /// The country the vehicle originated from.
        /// </summary>
        [JsonPropertyName("CountryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// SMMT data version number.
        /// </summary>
        [JsonPropertyName("DataVersionNumber")]
        public double? DataVersionNumber { get; set; }

        /// <summary>
        /// Identifies the number of wheels the vehicle has and how many of them are driving the
        /// vehicle.  E.g. '4x2' or '4x4'.
        /// </summary>
        [JsonPropertyName("DriveType")]
        public string DriveType { get; set; }

        /// <summary>
        /// The exact engine cubic capacity in cubic centimetres e.g. '1998' (whereas
        /// NominalEngineCapacity cc may be given as '2.0L').
        /// </summary>
        [JsonPropertyName("EngineCapacity")]
        public string EngineCapacity { get; set; }

        /// <summary>
        /// Type of fuel or power source used. E.g. 'Petrol'.
        /// </summary>
        [JsonPropertyName("FuelType")]
        public string FuelType { get; set; }

        /// <summary>
        /// SMMT 2 digit market sector of the model variant: E.g. 'AA' = 'CAR (EXC. OFF ROAD)' and 'DC'
        /// = 'LCVs ALL 2601 - 3500 KGS'.
        /// </summary>
        [JsonPropertyName("MarketSectorCode")]
        public string MarketSectorCode { get; set; }

        /// <summary>
        /// The 'badge' on the vehicle.  E.g. 'Ford', 'Vauxhall', etc.
        /// </summary>
        [JsonPropertyName("Marque")]
        public string Marque { get; set; }

        /// <summary>
        /// Two digit code that identifies the marque of the vehicle.
        /// </summary>
        [JsonPropertyName("MarqueCode")]
        public string MarqueCode { get; set; }

        /// <summary>
        /// 2 or 3 digit code that identifies the model of the vehicle.
        /// </summary>
        [JsonPropertyName("ModelCode")]
        public string ModelCode { get; set; }

        /// <summary>
        /// Vehicle model and trim as detailed by the manufacturer.
        /// </summary>
        [JsonPropertyName("ModelVariant")]
        public string ModelVariant { get; set; }

        /// <summary>
        /// The approximate engine  capacity in cubic centimetres e.g. 2.0L (whereas EngineCapacity
        /// is the exact engine capacity.
        /// </summary>
        [JsonPropertyName("NominalEngineCapacity")]
        public double? NominalEngineCapacity { get; set; }

        /// <summary>
        /// The number of doors on a passenger car.
        /// </summary>
        [JsonPropertyName("NumberOfDoors")]
        public long? NumberOfDoors { get; set; }

        /// <summary>
        /// The number of gears (forward driving gear ratios) in the vehicle transmission.  E.g. '6'.
        /// </summary>
        [JsonPropertyName("NumberOfGears")]
        public long? NumberOfGears { get; set; }

        /// <summary>
        /// The collective name for a family of model variants.  E.g. 'MONDEO', 'FOCUS', 'ASTRA'.
        /// </summary>
        [JsonPropertyName("Range")]
        public string Range { get; set; }

        /// <summary>
        /// The factory code or the manufacturer's internal code which distinguishes the evolution of
        /// the model from the previous version. Series enables a vehicle within a model range to be
        /// distinguished from other models in the same model range. The differences do not qualify
        /// the vehicle to be described as a new Range because the modifications only amount to a
        /// 'face lift'.
        /// </summary>
        [JsonPropertyName("Series")]
        public string Series { get; set; }

        /// <summary>
        /// Identifies the model variant system setup date of the vehicle.
        /// </summary>
        [JsonPropertyName("SysSetupDate")]
        [JsonConverter(typeof(DayMonthYearDateConverter))]
        public DateTime? SysSetupDate { get; set; }

        /// <summary>
        /// Identifies the model variant termination date of the vehicle.
        /// </summary>
        [JsonPropertyName("TerminateDate")]
        public string TerminateDate { get; set; }

        /// <summary>
        /// A description of the Transmission Type.  E.g. 'Automatic', 'CVT', 'Manual'.
        /// </summary>
        [JsonPropertyName("Transmission")]
        public string Transmission { get; set; }

        /// <summary>
        /// Identifies the model variant visibility date of the vehicle.
        /// </summary>
        [JsonPropertyName("VisibilityDate")]
        [JsonConverter(typeof(DayMonthYearDateConverter))]
        public DateTime? VisibilityDate { get; set; }
    }
}
