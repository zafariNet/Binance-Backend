using System.Threading.Tasks;
using Abp.Application.Services;
using Maya.Project.MultiTenancy.Payments.PayPal.Dto;

namespace Maya.Project.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
