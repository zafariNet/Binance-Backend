using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Maya.Project.MultiTenancy.Accounting.Dto;

namespace Maya.Project.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
