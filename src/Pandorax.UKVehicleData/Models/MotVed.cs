using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class MotVed
    {
        /// <summary>
        /// When appropriate, the message field will contain:  'No details found' OR 'Timeout
        /// exceeded waiting for response' (The MOT/tax data is live sourced when the package request
        /// is processed, if the MOT/tax data request exceeds a preset time limit the timeout message
        /// is returned).
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }

        /// <summary>
        /// Date of Mot due.  (This could either be the 'Expired' or 'Expires' date) e.g. 01/09/2015
        /// (When no MOT data is available on the vehicle then 'No details held by DVLA' will be
        /// returned).  (When no details are held at all then this field will be blank).
        /// </summary>
        [JsonPropertyName("MotDue")]
        public string MotDue { get; set; }

        /// <summary>
        /// Date of Tax due.  (This could either be the 'Expired' or 'Expires' date) e.g. 01/09/2015
        /// (When no details are held at all then this field will be blank).
        /// </summary>
        [JsonPropertyName("TaxDue")]
        public string TaxDue { get; set; }

        /// <summary>
        /// VED band (may differ from VedCo2Band).
        /// </summary>
        [JsonPropertyName("VedBand")]
        public string VedBand { get; set; }

        /// <summary>
        /// VED CO2 band.
        /// </summary>
        [JsonPropertyName("VedCo2Band")]
        public string VedCo2Band { get; set; }

        /// <summary>
        /// VED CO2 emissions figure expressed in g/km.
        /// </summary>
        [JsonPropertyName("VedCo2Emissions")]
        public double? VedCo2Emissions { get; set; }

        [JsonPropertyName("VedRate")]
        public VedRate VedRate { get; set; }

        /// <summary>
        /// The current tax status on the vehicle.  Current status values are: 'Not taxed', 'Not
        /// taxed keeper change', 'SORN in place', 'Tax not due', 'Taxed and due'.  (When no details
        /// are held at all then this field will be blank).
        /// </summary>
        [JsonPropertyName("VehicleStatus")]
        public string VehicleStatus { get; set; }
    }
}
