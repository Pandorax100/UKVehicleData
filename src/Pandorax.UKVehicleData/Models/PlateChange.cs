using System;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class PlateChange
    {
        [JsonPropertyName("CurrentVRM")]
        public string CurrentVrm { get; set; }

        /// <summary>
        /// Date of receipt for the transfer.
        /// </summary>
        public DateTimeOffset DateOfReceipt { get; set; }

        public DateTimeOffset DateOfTransaction { get; set; }

        [JsonPropertyName("PreviousVRM")]
        public string PreviousVrm { get; set; }

        public string TransferType { get; set; }
    }
}
