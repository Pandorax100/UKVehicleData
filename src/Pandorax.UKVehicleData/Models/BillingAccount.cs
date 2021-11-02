using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class BillingAccount
    {
        [JsonPropertyName("AccountType")]
        public string AccountType { get; set; }

        [JsonPropertyName("AccountBalance")]
        public double AccountBalance { get; set; }

        [JsonPropertyName("TransactionCost")]
        public double TransactionCost { get; set; }

        [JsonPropertyName("ExtraInformation")]
        public ExtraInformation ExtraInformation { get; set; }
    }
}
