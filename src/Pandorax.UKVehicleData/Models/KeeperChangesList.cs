using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class KeeperChangesList
    {
        /// <summary>
        /// Date of last keeper change.
        /// </summary>
        [JsonPropertyName("DateOfLastKeeperChange")]
        public string DateOfLastKeeperChange { get; set; }

        /// <summary>
        /// Date of transaction.
        /// </summary>
        [JsonPropertyName("DateOfTransaction")]
        public string DateOfTransaction { get; set; }

        /// <summary>
        /// Number of previous keepers.
        /// </summary>
        [JsonPropertyName("NumberOfPreviousKeepers")]
        public long? NumberOfPreviousKeepers { get; set; }
    }
}