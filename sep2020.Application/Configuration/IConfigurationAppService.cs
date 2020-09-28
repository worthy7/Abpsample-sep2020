using System.Threading.Tasks;
using Abp.Application.Services;
using sep2020.Configuration.Dto;

namespace sep2020.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}