using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class StatusInformation
    {
        [JsonPropertyName("Lookup")]
        public Lookup Lookup { get; set; }
    }
}
