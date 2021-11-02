using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class EuroNcap
    {
        [JsonPropertyName("Child")]
        public double Child { get; set; }

        [JsonPropertyName("Adult")]
        public double Adult { get; set; }

        [JsonPropertyName("Pedestrian")]
        public double Pedestrian { get; set; }
    }
}
