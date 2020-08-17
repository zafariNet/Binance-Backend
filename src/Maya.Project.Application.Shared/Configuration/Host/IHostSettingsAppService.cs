using System.Threading.Tasks;
using Abp.Application.Services;
using Maya.Project.Configuration.Host.Dto;

namespace Maya.Project.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
