using System.Threading.Tasks;
using Abp.Webhooks;

namespace Maya.Project.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
