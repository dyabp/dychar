using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DyCompanyName.DyProjectName.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class DyProjectNameMigrationsDbContextFactory : IDesignTimeDbContextFactory<DyProjectNameMigrationsDbContext>
    {
        public DyProjectNameMigrationsDbContext CreateDbContext(string[] args)
        {
            DyProjectNameEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DyProjectNameMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new DyProjectNameMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DyCompanyName.DyProjectName.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
