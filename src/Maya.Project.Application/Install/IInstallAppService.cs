using System.Threading.Tasks;
using Abp.Application.Services;
using Maya.Project.Install.Dto;

namespace Maya.Project.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}