using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Maya.Project.Common.Dto;
using Maya.Project.Editions.Dto;

namespace Maya.Project.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}