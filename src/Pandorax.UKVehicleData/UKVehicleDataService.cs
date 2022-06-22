using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Pandorax.UKVehicleData.Models;
using Pandorax.UKVehicleData.Options;

namespace Pandorax.UKVehicleData
{
    public class UKVehicleDataService : IUKVehicleDataService
    {
        private readonly HttpClient _client;
        private readonly ILogger<UKVehicleDataService> _logger;
        private readonly UKVehicleDataOptions _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="UKVehicleDataService"/> class.
        /// </summary>
        /// <param name="client">The <see cref="HttpClient"/> with which to make API calls.</param>
        /// <param name="options">The options accessor.</param>
        /// <param name="logger">The logger instance for this class.</param>
        public UKVehicleDataService(
            HttpClient client,
            IOptions<UKVehicleDataOptions> options,
            ILogger<UKVehicleDataService> logger)
        {
            _client = client;
            _logger = logger;
            _options = options.Value;
        }

        /// <inheritdoc/>
        public async Task<UKVehicleDataResponse> GetVehicleDetailsAsync(string registrationNumber)
        {
            _logger.LogDebug("Getting response for {Registration}", registrationNumber);

            using HttpResponseMessage response = await _client.GetAsync($"/api/datapackage/VehicleData?v=2&auth_apikey={_options.ApiKey}&key_VRM={registrationNumber}");

            string json = await response.Content.ReadAsStringAsync();

            _logger.LogDebug("Response for {Registration}\n{Json}", registrationNumber, json);

            var deserialized = JsonSerializer.Deserialize<UKVehicleDataResponse>(json);

            return deserialized;
        }
    }
}
