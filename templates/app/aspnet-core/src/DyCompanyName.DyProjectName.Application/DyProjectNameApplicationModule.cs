using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Dyabp.LanguageManagement;

namespace DyCompanyName.DyProjectName
{
    [DependsOn(
        typeof(DyProjectNameDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(DyProjectNameApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(LanguageManagementApplicationModule)
        )]
    public class DyProjectNameApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<DyProjectNameApplicationModule>();
            });
        }
    }
}
