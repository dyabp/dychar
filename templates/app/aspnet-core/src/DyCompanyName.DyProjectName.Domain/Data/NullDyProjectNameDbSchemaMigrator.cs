using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DyCompanyName.DyProjectName.Data
{
    /* This is used if database provider does't define
     * IDyProjectNameDbSchemaMigrator implementation.
     */
    public class NullDyProjectNameDbSchemaMigrator : IDyProjectNameDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}