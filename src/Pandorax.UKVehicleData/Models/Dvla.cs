using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Dvla
    {
        [JsonPropertyName("Model")]
        public string Model { get; set; }

        [JsonPropertyName("Make")]
        public string Make { get; set; }
    }
}
