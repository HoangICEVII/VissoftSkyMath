using System.Runtime.CompilerServices;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //bao gom cac service dependency injection
            services.AddScoped<VissoftDatabaseContext, VissoftDatabaseContext>();
            return services;
        }
    }
}
