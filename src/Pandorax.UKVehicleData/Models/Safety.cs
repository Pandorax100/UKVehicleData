using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Safety
    {
        [JsonPropertyName("EuroNcap")]
        public EuroNcap EuroNcap { get; set; }
    }
}
