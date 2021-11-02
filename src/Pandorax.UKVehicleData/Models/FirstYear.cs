using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class FirstYear
    {
        [JsonPropertyName("SixMonth")]
        public double? SixMonth { get; set; }

        [JsonPropertyName("TwelveMonth")]
        public long? TwelveMonth { get; set; }
    }
}
