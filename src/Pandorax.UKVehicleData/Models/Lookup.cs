using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Lookup
    {
        [JsonPropertyName("StatusCode")]
        public string StatusCode { get; set; }

        [JsonPropertyName("StatusMessage")]
        public string StatusMessage { get; set; }

        [JsonPropertyName("AdviceTextList")]
        public List<object> AdviceTextList { get; set; }
    }
}
