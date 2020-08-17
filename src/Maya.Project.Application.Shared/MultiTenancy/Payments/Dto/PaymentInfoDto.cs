using Maya.Project.Editions.Dto;

namespace Maya.Project.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < ProjectConsts.MinimumUpgradePaymentAmount;
        }
    }
}
