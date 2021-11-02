using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class SmmtDetails
    {
        [JsonPropertyName("Range")]
        public string Range { get; set; }

        [JsonPropertyName("FuelType")]
        public string FuelType { get; set; }

        [JsonPropertyName("EngineCapacity")]
        public long EngineCapacity { get; set; }

        [JsonPropertyName("MarketSectorCode")]
        public string MarketSectorCode { get; set; }

        [JsonPropertyName("CountryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [JsonPropertyName("ModelCode")]
        public long ModelCode { get; set; }

        [JsonPropertyName("ModelVariant")]
        public string ModelVariant { get; set; }

        [JsonPropertyName("DataVersionNumber")]
        public object DataVersionNumber { get; set; }

        [JsonPropertyName("NumberOfGears")]
        public long NumberOfGears { get; set; }

        [JsonPropertyName("NominalEngineCapacity")]
        public long NominalEngineCapacity { get; set; }

        [JsonPropertyName("MarqueCode")]
        public string MarqueCode { get; set; }

        [JsonPropertyName("Transmission")]
        public string Transmission { get; set; }

        [JsonPropertyName("BodyStyle")]
        public string BodyStyle { get; set; }

        [JsonPropertyName("VisibilityDate")]
        public string VisibilityDate { get; set; }

        [JsonPropertyName("SysSetupDate")]
        public string SysSetupDate { get; set; }

        [JsonPropertyName("Marque")]
        public string Marque { get; set; }

        [JsonPropertyName("CabType")]
        public string CabType { get; set; }

        [JsonPropertyName("TerminateDate")]
        public object TerminateDate { get; set; }

        [JsonPropertyName("Series")]
        public string Series { get; set; }

        [JsonPropertyName("NumberOfDoors")]
        public long NumberOfDoors { get; set; }

        [JsonPropertyName("DriveType")]
        public string DriveType { get; set; }
    }
}
