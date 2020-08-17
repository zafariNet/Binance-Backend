using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Maya.Project.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
