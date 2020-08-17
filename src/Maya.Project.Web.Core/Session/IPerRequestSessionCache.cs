using System.Threading.Tasks;
using Maya.Project.Sessions.Dto;

namespace Maya.Project.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
