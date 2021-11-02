using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class VrmFormat
    {
        /// <summary>
        /// Set to true if the VRM format matches one of the formats used for general registrations
        /// in Great Britain.
        /// </summary>
        [JsonPropertyName("IsGbGeneralFormat")]
        public bool? IsGbGeneralFormat { get; set; }

        /// <summary>
        /// Set to true if the VRM format matches one of the formats used for general registrations
        /// in Northern Ireland.
        /// </summary>
        [JsonPropertyName("IsNiGeneralFormat")]
        public bool? IsNiGeneralFormat { get; set; }
    }
}
