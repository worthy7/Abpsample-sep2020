using System.Threading.Tasks;
using Abp.Application.Services;
using sep2020.Sessions.Dto;

namespace sep2020.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
