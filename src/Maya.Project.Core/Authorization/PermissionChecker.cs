using Abp.Authorization;
using Maya.Project.Authorization.Roles;
using Maya.Project.Authorization.Users;

namespace Maya.Project.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
