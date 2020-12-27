using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace DyCompanyName.DyProjectName.EntityFrameworkCore
{
    public static class DyProjectNameDbContextModelCreatingExtensions
    {
        public static void ConfigureDyProjectName(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DyProjectNameConsts.DbTablePrefix + "YourEntities", DyProjectNameConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}