using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentAccounting.Core.Services;
using StudentAccounting.Core.Services.Abstractions;
using StudentAccounting.Infrastructure;

namespace StudentAccounting.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructure(configuration);

            services.AddScoped<IUniqueCheckService, StudentUniqueCheckService>();

            services.AddTransient<IStudentService, StudentService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
