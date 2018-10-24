using Abp.Authorization;
using MPAPhoneProject.Authorization.Roles;
using MPAPhoneProject.Authorization.Users;

namespace MPAPhoneProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
