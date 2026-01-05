using System;
using Microsoft.Extensions.DependencyInjection;
using Pandorax.UKVehicleData.Options;

namespace Pandorax.UKVehicleData.DependencyInjection
{
    /// <summary>
    /// A class containing helper extension methods to add the UK Vehicle Data service to the service collection.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        ///     <para>Registeres the UK Vehicle Enquiry Service to the <see cref="IServiceCollection"/>.</para>
        ///     <para>
        ///         Use this method when using dependency injection in your application, such as with ASP.NET Core.
        ///         For applications that don't use dependency injection, consider creating <see cref="UKVehicleDataService" />
        ///         instances directly with its constructor.
        ///     </para>
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
        /// <param name="apiKey">
        /// <para>Your UK vehicle data API key.</para>
        /// <para>If you do not have an api key one can be obtained from the UK Vehicle Data website.</para>
        /// </param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddUKVehicleData(this IServiceCollection services, string apiKey)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException($"'{nameof(apiKey)}' cannot be null or empty.", nameof(apiKey));
            }

            services.Configure<UKVehicleDataOptions>(options =>
            {
                options.ApiKey = apiKey;
            });

            services.AddHttpClient<IUKVehicleDataService, UKVehicleDataService>(client =>
            {
                client.BaseAddress = new Uri(UKVehicleDataConstants.BaseApiUrl);
            });

            return services;
        }
    }
}
