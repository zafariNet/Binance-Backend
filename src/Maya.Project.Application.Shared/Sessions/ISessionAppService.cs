using System.Threading.Tasks;
using Abp.Application.Services;
using Maya.Project.Sessions.Dto;

namespace Maya.Project.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
