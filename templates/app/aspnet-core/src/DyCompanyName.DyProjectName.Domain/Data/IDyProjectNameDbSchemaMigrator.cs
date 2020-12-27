using System.Threading.Tasks;

namespace DyCompanyName.DyProjectName.Data
{
    public interface IDyProjectNameDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
