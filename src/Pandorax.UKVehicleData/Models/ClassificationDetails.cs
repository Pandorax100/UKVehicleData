﻿using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class ClassificationDetails
    {
        [JsonPropertyName("Smmt")]
        public Smmt Smmt { get; set; }

        [JsonPropertyName("Dvla")]
        public Dvla Dvla { get; set; }

        [JsonPropertyName("Ukvd")]
        public Ukvd Ukvd { get; set; }
    }
}
