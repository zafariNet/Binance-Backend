using System.Threading.Tasks;
using Abp.Dependency;

namespace Maya.Project.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}