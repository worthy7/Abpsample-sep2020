using Abp.Authorization;
using sep2020.Authorization.Roles;
using sep2020.Authorization.Users;

namespace sep2020.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
