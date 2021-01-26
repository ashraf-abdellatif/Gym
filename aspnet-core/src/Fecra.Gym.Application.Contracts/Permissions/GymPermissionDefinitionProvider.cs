using Fecra.Gym.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Fecra.Gym.Permissions
{
    public class GymPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(GymPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(GymPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GymResource>(name);
        }
    }
}
