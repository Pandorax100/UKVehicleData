using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class UKVehicleDataResponse
    {
        [JsonPropertyName("BillingAccount")]
        public BillingAccount BillingAccount { get; set; }

        [JsonPropertyName("TechnicalSupport")]
        public TechnicalSupport TechnicalSupport { get; set; }

        [JsonPropertyName("Request")]
        public Request Request { get; set; }

        [JsonPropertyName("Response")]
        public Response Response { get; set; }
    }
}
