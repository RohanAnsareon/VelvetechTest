
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentAccounting.Infrastructure;

namespace StudentAccounting.API.HostedServices
{
    public class MigrationHostedService : IHostedService
    {
        //private readonly IServiceProvider _provider;

        //public MigrationHostedService(IServiceProvider provider)
        //{
        //    _provider = provider;
        //}

        //public async Task StartAsync(CancellationToken cancellationToken)
        //{
        //    var context = _provider.GetRequiredService<StudentAccountingDbContext>();
        //    await context.Database.MigrateAsync(cancellationToken);
        //}

        //public Task StopAsync(CancellationToken cancellationToken)
        //{
        //    return Task.CompletedTask;
        //}

        private IServiceProvider Services { get; }

        public MigrationHostedService(IServiceProvider services)
        {
            Services = services;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<StudentAccountingDbContext>();
            await context.Database.MigrateAsync(cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
