using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using sep2020.Roles.Dto;
using sep2020.Users.Dto;

namespace sep2020.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}