using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using sep2020.Authorization.Users;
using sep2020.Users;

namespace sep2020.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
