using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StudentAccounting.API.HostedServices;

namespace StudentAccounting.API.Configs
{
    public static class HostedServicesConfig
    {
        public static IServiceCollection AddHostedServices(this IServiceCollection services)
        {
            services.AddHostedService<MigrationHostedService>();

            return services;
        }
    }
}
