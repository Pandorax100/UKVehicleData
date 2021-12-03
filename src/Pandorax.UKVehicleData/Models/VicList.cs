using System;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class VicList
    {
        /// <summary>
        /// Date of VIC test.
        /// </summary>
        [JsonPropertyName("VICDate")]
        public DateTime? VicDate { get; set; }

        /// <summary>
        /// Result of the VIC test.  Value will be 'PASS' or 'FAIL'.
        /// </summary>
        [JsonPropertyName("VICResult")]
        public string VicResult { get; set; }
    }
}
