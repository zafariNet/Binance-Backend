using Abp.AspNetCore.Mvc.Authorization;
using Maya.Project.Authorization;
using Maya.Project.Storage;
using Abp.BackgroundJobs;

namespace Maya.Project.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}