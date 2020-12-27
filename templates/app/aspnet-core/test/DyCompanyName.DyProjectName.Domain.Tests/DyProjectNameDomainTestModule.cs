using DyCompanyName.DyProjectName.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DyCompanyName.DyProjectName
{
    [DependsOn(
        typeof(DyProjectNameEntityFrameworkCoreTestModule)
        )]
    public class DyProjectNameDomainTestModule : AbpModule
    {

    }
}