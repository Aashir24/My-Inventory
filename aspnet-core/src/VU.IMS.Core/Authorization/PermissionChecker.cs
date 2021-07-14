using Abp.Authorization;
using VU.IMS.Authorization.Roles;
using VU.IMS.Authorization.Users;

namespace VU.IMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
