using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Maya.Project.Caching.Dto;

namespace Maya.Project.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
