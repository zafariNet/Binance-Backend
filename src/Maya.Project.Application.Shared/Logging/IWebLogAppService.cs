using Abp.Application.Services;
using Maya.Project.Dto;
using Maya.Project.Logging.Dto;

namespace Maya.Project.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
