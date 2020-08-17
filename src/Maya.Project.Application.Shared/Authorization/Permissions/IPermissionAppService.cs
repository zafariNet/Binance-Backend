using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Maya.Project.Authorization.Permissions.Dto;

namespace Maya.Project.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
