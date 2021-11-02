using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Dvla
    {
        /// <summary>
        /// Vehicle make as defined by DVLA.
        /// </summary>
        [JsonPropertyName("Make")]
        public string Make { get; set; }

        /// <summary>
        /// Vehicle model as defined by DVLA.
        /// </summary>
        [JsonPropertyName("Model")]
        public string Model { get; set; }
    }
}
