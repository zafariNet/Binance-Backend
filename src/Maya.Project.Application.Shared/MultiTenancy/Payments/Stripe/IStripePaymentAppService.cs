using System.Threading.Tasks;
using Abp.Application.Services;
using Maya.Project.MultiTenancy.Payments.Dto;
using Maya.Project.MultiTenancy.Payments.Stripe.Dto;

namespace Maya.Project.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}