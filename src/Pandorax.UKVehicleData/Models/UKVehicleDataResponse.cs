using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class UKVehicleDataResponse
    {
        [JsonPropertyName("Request")]
        public Request Request { get; set; }

        [JsonPropertyName("Response")]
        public Response Response { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [JsonPropertyName("Message")]
        public string ErrorMessage { get; set; }

        public AuthenticationFailureDetails AuthenticationFailureDetails { get; set; }
    }
}
