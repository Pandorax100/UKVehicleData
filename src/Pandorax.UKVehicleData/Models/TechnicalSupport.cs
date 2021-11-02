using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandorax.UKVehicleData.JsonConverters;

namespace Pandorax.UKVehicleData.Models
{
    public class TechnicalSupport
    {
        [JsonPropertyName("ServerId")]
        public string ServerId { get; set; }

        [JsonPropertyName("RequestId")]
        public string RequestId { get; set; }

        [JsonPropertyName("QueryDurationMs")]
        public long QueryDurationMs { get; set; }

        [JsonPropertyName("SupportDate")]
        [JsonConverter(typeof(SupportDateConverter))]
        public DateTime SupportDate { get; set; }

        [JsonPropertyName("SupportTime")]
        [JsonConverter(typeof(SupportTimeConverter))]
        public DateTime SupportTime { get; set; }

        [JsonPropertyName("SupportCode")]
        public string SupportCode { get; set; }

        [JsonPropertyName("SupportInformationList")]
        public List<string> SupportInformationList { get; set; }
    }
}
