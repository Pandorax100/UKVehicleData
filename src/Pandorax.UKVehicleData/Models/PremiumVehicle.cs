using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class PremiumVehicle
    {
        [JsonPropertyName("YearTwoToSix")]
        public YearTwoToSix YearTwoToSix { get; set; }
    }
}
