using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class PlateChangeList
    {
        /// <summary>
        /// Current VRM
        /// </summary>
        [JsonPropertyName("CurrentVRM")]
        public string CurrentVrm { get; set; }

        /// <summary>
        /// Date of receipt for the transfer.
        /// </summary>
        [JsonPropertyName("DateOfReceipt")]
        public string DateOfReceipt { get; set; }

        /// <summary>
        /// Date of transaction.
        /// </summary>
        [JsonPropertyName("DateOfTransaction")]
        public string DateOfTransaction { get; set; }

        /// <summary>
        /// Previous VRM.
        /// </summary>
        [JsonPropertyName("PreviousVRM")]
        public string PreviousVrm { get; set; }

        /// <summary>
        /// Type of transfer.
        /// </summary>
        [JsonPropertyName("TransferType")]
        public string TransferType { get; set; }
    }
}
