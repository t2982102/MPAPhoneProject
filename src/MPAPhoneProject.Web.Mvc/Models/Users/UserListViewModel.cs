using System.Collections.Generic;
using MPAPhoneProject.Roles.Dto;
using MPAPhoneProject.Users.Dto;

namespace MPAPhoneProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
