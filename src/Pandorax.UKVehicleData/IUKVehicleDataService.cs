using System.Threading.Tasks;
using Pandorax.UKVehicleData.Models;

namespace Pandorax.UKVehicleData
{
    public interface IUKVehicleDataService
    {
        /// <summary>
        /// Gets the data for the vehicle with the supplied registration number.
        /// </summary>
        /// <param name="registrationNumber">The registration number of the vehicle.</param>
        /// <returns>A <see cref="Task"/> representing the asyncronous operation.</returns>
        Task<UKVehicleDataResponse> GetVehicleDetailsAsync(string registrationNumber);
    }
}
