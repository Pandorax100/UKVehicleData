using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Mvris
    {
        [JsonPropertyName("ModelCode")]
        public string ModelCode { get; set; }

        [JsonPropertyName("MakeCode")]
        public string MakeCode { get; set; }
    }
}
