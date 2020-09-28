using Abp.Application.Services;
using Abp.Application.Services.Dto;
using sep2020.MultiTenancy.Dto;

namespace sep2020.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
