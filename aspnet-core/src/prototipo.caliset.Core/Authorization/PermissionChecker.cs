using Abp.Authorization;
using prototipo.caliset.Authorization.Roles;
using prototipo.caliset.Authorization.Users;

namespace prototipo.caliset.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
