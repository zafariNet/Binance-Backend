using System.Threading.Tasks;
using Abp.Application.Services;

namespace Maya.Project.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
