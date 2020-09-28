using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using sep2020.MultiTenancy;

namespace sep2020.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}