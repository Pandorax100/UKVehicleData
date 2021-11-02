using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class FuelConsumption
    {
        /// <summary>
        /// Fuel efficiency in litres per 100km for the 'combined' engine cycle as stipulated in
        /// Directive 1999/100/EC. The combined figure presented is for the urban and the extra-urban
        /// cycle together. It is therefore an average of the two other parts of the fuel consumption
        /// test, Urban and Extra-urban cycles, weighted by the distance covered in each part.
        /// </summary>
        [JsonPropertyName("Lkm")]
        public double? Lkm { get; set; }

        /// <summary>
        /// Fuel efficiency in miles per gallon for the 'combined' engine cycle as stipulated in
        /// Directive 1999/100/EC. The combined figure presented is for the urban and the extra-urban
        /// cycle together. It is therefore an average of the two other parts of the fuel consumption
        /// test, Urban and Extra-urban cycles, weighted by the distance covered in each part.
        /// </summary>
        [JsonPropertyName("Mpg")]
        public double? Mpg { get; set; }
    }
}
