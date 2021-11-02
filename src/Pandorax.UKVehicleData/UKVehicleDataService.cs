using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Pandorax.UKVehicleData.Models;

namespace Pandorax.UKVehicleData
{
    public class UKVehicleDataService : IUKVehicleDataService
    {
        private readonly HttpClient _client;
        private readonly UKVehicleDataOptions _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="UKVehicleDataService"/> class.
        /// </summary>
        /// <param name="client">The <see cref="HttpClient"/> with which to make API calls.</param>
        /// <param name="options">The options accessor.</param>
        public UKVehicleDataService(HttpClient client, IOptions<UKVehicleDataOptions> options)
        {
            _client = client;
            _options = options.Value;
        }

        /// <inheritdoc/>
        public async Task<UKVehicleDataResponse> GetVehicleDataByRegistrationNumberAsync(string registration)
        {
            using HttpResponseMessage response = await _client.GetAsync($"/api/datapackage/VehicleData?v=2&auth_apikey={_options.ApiKey}&key_VRM={registration}");

            string json = await response.Content.ReadAsStringAsync();

            var deserialized = JsonSerializer.Deserialize<UKVehicleDataResponse>(json);

            return deserialized;
        }
    }
}
