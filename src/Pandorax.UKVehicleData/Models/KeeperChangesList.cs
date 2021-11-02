using System;
using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class KeeperChangesList
    {
        [JsonPropertyName("DateOfTransaction")]
        public DateTimeOffset DateOfTransaction { get; set; }

        [JsonPropertyName("NumberOfPreviousKeepers")]
        public long NumberOfPreviousKeepers { get; set; }

        [JsonPropertyName("DateOfLastKeeperChange")]
        public DateTimeOffset DateOfLastKeeperChange { get; set; }
    }
}
