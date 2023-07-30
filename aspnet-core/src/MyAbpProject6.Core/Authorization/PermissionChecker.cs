using Abp.Authorization;
using MyAbpProject6.Authorization.Roles;
using MyAbpProject6.Authorization.Users;

namespace MyAbpProject6.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
