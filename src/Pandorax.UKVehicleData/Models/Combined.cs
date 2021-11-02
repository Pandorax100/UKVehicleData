using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Combined
    {
        [JsonPropertyName("Lkm")]
        public double Lkm { get; set; }

        [JsonPropertyName("Mpg")]
        public double Mpg { get; set; }
    }
}
