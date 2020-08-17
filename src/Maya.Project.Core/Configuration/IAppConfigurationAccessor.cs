using Microsoft.Extensions.Configuration;

namespace Maya.Project.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
