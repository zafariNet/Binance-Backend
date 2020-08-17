using System.Threading.Tasks;

namespace Maya.Project.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}