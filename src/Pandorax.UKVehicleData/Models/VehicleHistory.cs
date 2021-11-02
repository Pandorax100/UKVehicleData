using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class VehicleHistory
    {
        /// <summary>
        /// Count of entries in the V5C certificate list.
        /// </summary>
        [JsonPropertyName("V5CCertificateCount")]
        public long V5CCertificateCount { get; set; }

        /// <summary>
        /// Count of elements in the plate change list.
        /// </summary>
        [JsonPropertyName("PlateChangeCount")]
        public long PlateChangeCount { get; set; }

        /// <summary>
        /// This is the number of previous keepers for this vehicle.
        /// </summary>
        [JsonPropertyName("NumberOfPreviousKeepers")]
        public long NumberOfPreviousKeepers { get; set; }

        /// <summary>
        /// List of V5C certificate details.
        /// </summary>
        [JsonPropertyName("V5CCertificateList")]
        public List<V5CCertificateList> V5CCertificateList { get; set; }

        /// <summary>
        /// Number of records in the KeeperChangesList.
        /// </summary>
        [JsonPropertyName("KeeperChangesCount")]
        public long KeeperChangesCount { get; set; }

        /// <summary>
        /// Count of entries in the Vehicle Id Check list.
        /// </summary>
        [JsonPropertyName("VicCount")]
        public long VicCount { get; set; }

        [JsonPropertyName("ColourChangeCount")]
        public int ColourChangeCount { get; set; }

        [JsonPropertyName("ColourChangeList")]
        public List<object> ColourChangeList { get; set; }

        [JsonPropertyName("KeeperChangesList")]
        public List<KeeperChangesList> KeeperChangesList { get; set; }

        /// <summary>
        /// List of plate change details.
        /// </summary>
        [JsonPropertyName("PlateChangeList")]
        public List<PlateChange> PlateChangeList { get; set; }

        /// <summary>
        /// List of Vehicle Id Check details.
        /// </summary>
        [JsonPropertyName("VicList")]
        public List<VehicleIdCheckDetails> VicList { get; set; }
    }
}
