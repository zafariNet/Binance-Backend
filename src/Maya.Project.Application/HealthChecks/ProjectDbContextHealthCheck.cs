using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Maya.Project.EntityFrameworkCore;

namespace Maya.Project.HealthChecks
{
    public class ProjectDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public ProjectDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("ProjectDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("ProjectDbContext could not connect to database"));
        }
    }
}
