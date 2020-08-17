using System.Threading.Tasks;
using Maya.Project.Authorization.Users;

namespace Maya.Project.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
