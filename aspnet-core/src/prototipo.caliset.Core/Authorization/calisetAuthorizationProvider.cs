using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace prototipo.caliset.Authorization
{
    public class calisetAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Usersssssss"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Operaciones, L("Algo"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, calisetConsts.LocalizationSourceName);
        }
    }
}
