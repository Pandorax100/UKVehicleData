using System;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class V5CCertificateList
    {
        /// <summary>
        /// Date for this certificate.
        /// </summary>
        [JsonPropertyName("CertificateDate")]
        public DateTimeOffset CertificateDate { get; set; }
    }
}
