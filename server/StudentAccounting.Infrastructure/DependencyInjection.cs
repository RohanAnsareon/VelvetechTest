using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentAccounting.Shared.Interfaces;

namespace StudentAccounting.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region DbContext
            var connectionString = configuration.GetConnectionString("Local");

            services.AddDbContext<StudentAccountingDbContext>(options =>
            {
                options.UseSqlServer(connectionString).UseLazyLoadingProxies();
            });

            services.AddScoped<StudentAccountingDbContext>();
            #endregion

            services.AddScoped(typeof(IRepository<>), typeof(StudentAccountingRepository<>));

            return services;
        }
    }
}
