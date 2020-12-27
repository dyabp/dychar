using DyCompanyName.DyProjectName.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DyCompanyName.DyProjectName.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DyProjectNameEntityFrameworkCoreDbMigrationsModule),
        typeof(DyProjectNameApplicationContractsModule)
        )]
    public class DyProjectNameDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
