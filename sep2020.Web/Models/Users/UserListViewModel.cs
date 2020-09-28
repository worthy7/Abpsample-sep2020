using System.Collections.Generic;
using sep2020.Roles.Dto;
using sep2020.Users.Dto;

namespace sep2020.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}