using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using sep2020.Roles.Dto;

namespace sep2020.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
