using System;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Request
    {
        [JsonPropertyName("RequestGuid")]
        public Guid RequestGuid { get; set; }

        [JsonPropertyName("PackageId")]
        public Guid PackageId { get; set; }

        [JsonPropertyName("PackageVersion")]
        public long PackageVersion { get; set; }

        [JsonPropertyName("ResponseVersion")]
        public long ResponseVersion { get; set; }

        [JsonPropertyName("DataKeys")]
        public DataKeys DataKeys { get; set; }
    }
}
