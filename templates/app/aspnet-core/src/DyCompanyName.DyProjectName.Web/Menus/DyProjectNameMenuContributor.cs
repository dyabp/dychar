using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using DyCompanyName.DyProjectName.Localization;
using DyCompanyName.DyProjectName.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace DyCompanyName.DyProjectName.Web.Menus
{
    public class DyProjectNameMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<DyProjectNameResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(DyProjectNameMenus.Home, l["Menu:Home"], "~/"));
        }
    }
}
