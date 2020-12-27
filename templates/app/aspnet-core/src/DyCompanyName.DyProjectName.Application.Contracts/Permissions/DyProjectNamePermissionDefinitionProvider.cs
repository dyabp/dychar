using DyCompanyName.DyProjectName.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DyCompanyName.DyProjectName.Permissions
{
    public class DyProjectNamePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DyProjectNamePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DyProjectNamePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DyProjectNameResource>(name);
        }
    }
}
