using Abp.Authorization;
using Mf.Authorization.Roles;
using Mf.Authorization.Users;

namespace Mf.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
