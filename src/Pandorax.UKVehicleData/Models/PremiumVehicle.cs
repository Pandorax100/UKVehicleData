using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class PremiumVehicle
    {
        [JsonPropertyName("YearTwoToSix")]
        public FirstYear YearTwoToSix { get; set; }
    }
}
