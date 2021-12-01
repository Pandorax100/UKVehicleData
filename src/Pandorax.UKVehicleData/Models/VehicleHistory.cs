using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class VehicleHistory
    {
        [JsonPropertyName("ColourChangeCount")]
        public int? ColourChangeCount { get; set; }

        [JsonPropertyName("ColourChangeList")]
        public object[] ColourChangeList { get; set; }

        /// <summary>
        /// Number of records in the KeeperChangesList.
        /// </summary>
        [JsonPropertyName("KeeperChangesCount")]
        public int? KeeperChangesCount { get; set; }

        /// <summary>
        /// List of keeper change records.
        /// </summary>
        [JsonPropertyName("KeeperChangesList")]
        public KeeperChangesList[] KeeperChangesList { get; set; } = new KeeperChangesList[0];

        /// <summary>
        /// This is the number of previous keepers for this vehicle.
        /// </summary>
        [JsonPropertyName("NumberOfPreviousKeepers")]
        public int? NumberOfPreviousKeepers { get; set; }

        /// <summary>
        /// Count of elements in the plate change list.
        /// </summary>
        [JsonPropertyName("PlateChangeCount")]
        public int? PlateChangeCount { get; set; }

        /// <summary>
        /// List of plate change details.
        /// </summary>
        [JsonPropertyName("PlateChangeList")]
        public PlateChangeList[] PlateChangeList { get; set; }

        /// <summary>
        /// Count of entries in the V5C certificate list.
        /// </summary>
        [JsonPropertyName("V5CCertificateCount")]
        public int? V5CCertificateCount { get; set; }

        /// <summary>
        /// List of V5C certificate details.
        /// </summary>
        [JsonPropertyName("V5CCertificateList")]
        public V5CCertificateList[] V5CCertificateList { get; set; }

        /// <summary>
        /// Count of entries in the Vehicle Id Check list.
        /// </summary>
        [JsonPropertyName("VicCount")]
        public int? VicCount { get; set; }

        /// <summary>
        /// List of Vehicle Id Check details.
        /// </summary>
        [JsonPropertyName("VicList")]
        public VicList[] VicList { get; set; }
    }
}
