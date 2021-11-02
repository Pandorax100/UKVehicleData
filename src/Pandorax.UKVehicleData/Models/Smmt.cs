using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Smmt
    {
        /// <summary>
        /// Vehicle make as defined by SMMT.
        /// </summary>
        [JsonPropertyName("Make")]
        public string Make { get; set; }

        [JsonPropertyName("Mvris")]
        public Mvris Mvris { get; set; }

        /// <summary>
        /// Vehicle range as defined by SMMT.
        /// </summary>
        [JsonPropertyName("Range")]
        public string Range { get; set; }

        /// <summary>
        /// Vehicle trim as defined by SMMT.
        /// </summary>
        [JsonPropertyName("Trim")]
        public string Trim { get; set; }
    }
}
