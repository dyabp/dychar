using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DyCompanyName.DyProjectName.Data;
using Volo.Abp.DependencyInjection;

namespace DyCompanyName.DyProjectName.EntityFrameworkCore
{
    public class EntityFrameworkCoreDyProjectNameDbSchemaMigrator
        : IDyProjectNameDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDyProjectNameDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DyProjectNameMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DyProjectNameMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}