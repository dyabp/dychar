using Volo.Abp.Modularity;

namespace DyCompanyName.DyProjectName
{
    [DependsOn(
        typeof(DyProjectNameApplicationModule),
        typeof(DyProjectNameDomainTestModule)
        )]
    public class DyProjectNameApplicationTestModule : AbpModule
    {

    }
}