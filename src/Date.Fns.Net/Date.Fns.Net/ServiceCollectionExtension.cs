using Date.Fns.Net.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Date.Fns.Net
{
    /// <summary>
    /// Static class to extend the <see cref="IServiceCollection"></see>
    /// </summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Add DateService <see cref="IDateService"/> to the service collection for dependency injection container
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDateService(this IServiceCollection services)
        {
            return services.AddScoped<IDateService, DateService>();
        }
    }
}
