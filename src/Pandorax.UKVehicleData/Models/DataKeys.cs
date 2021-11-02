using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class DataKeys
    {
        [JsonPropertyName("Vrm")]
        public string Vrm { get; set; }
    }
}
