using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace prototipo.caliset.Authorization
{
    public class calisetAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Operations, L("Operations"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, calisetConsts.LocalizationSourceName);
        }
    }
}
