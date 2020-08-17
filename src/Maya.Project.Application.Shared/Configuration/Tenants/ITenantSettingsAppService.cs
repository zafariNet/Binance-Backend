using System.Threading.Tasks;
using Abp.Application.Services;
using Maya.Project.Configuration.Tenants.Dto;

namespace Maya.Project.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
