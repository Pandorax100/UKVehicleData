using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Mvris
    {
        /// <summary>
        /// MVRIS make code.
        /// </summary>
        [JsonPropertyName("MakeCode")]
        public string MakeCode { get; set; }

        /// <summary>
        /// MVRIS model code.
        /// </summary>
        [JsonPropertyName("ModelCode")]
        public string ModelCode { get; set; }
    }
}
