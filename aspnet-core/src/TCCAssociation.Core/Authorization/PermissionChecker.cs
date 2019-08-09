using Abp.Authorization;
using TCCAssociation.Authorization.Roles;
using TCCAssociation.Authorization.Users;

namespace TCCAssociation.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
