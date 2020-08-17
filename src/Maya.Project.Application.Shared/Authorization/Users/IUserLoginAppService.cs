using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Maya.Project.Authorization.Users.Dto;

namespace Maya.Project.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
