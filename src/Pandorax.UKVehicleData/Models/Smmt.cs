using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Smmt
    {
        [JsonPropertyName("Make")]
        public string Make { get; set; }

        [JsonPropertyName("Mvris")]
        public Mvris Mvris { get; set; }

        [JsonPropertyName("Trim")]
        public string Trim { get; set; }

        [JsonPropertyName("Range")]
        public string Range { get; set; }
    }
}
