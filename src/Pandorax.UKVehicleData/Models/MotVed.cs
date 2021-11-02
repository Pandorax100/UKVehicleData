using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class MotVed
    {
        [JsonPropertyName("VedRate")]
        public VedRate VedRate { get; set; }

        [JsonPropertyName("VedCo2Emissions")]
        public long VedCo2Emissions { get; set; }

        [JsonPropertyName("MotDue")]
        public object MotDue { get; set; }

        [JsonPropertyName("VedBand")]
        public string VedBand { get; set; }

        [JsonPropertyName("VedCo2Band")]
        public object VedCo2Band { get; set; }

        [JsonPropertyName("TaxDue")]
        public object TaxDue { get; set; }

        [JsonPropertyName("Message")]
        public object Message { get; set; }

        [JsonPropertyName("VehicleStatus")]
        public object VehicleStatus { get; set; }
    }
}
