using System.Threading.Tasks;
using Abp.Application.Services;
using Maya.Project.Editions.Dto;
using Maya.Project.MultiTenancy.Dto;

namespace Maya.Project.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}