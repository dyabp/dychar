using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace DyCompanyName.DyProjectName.EntityFrameworkCore
{
    [DependsOn(
        typeof(DyProjectNameEntityFrameworkCoreModule)
        )]
    public class DyProjectNameEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DyProjectNameMigrationsDbContext>();
        }
    }
}
