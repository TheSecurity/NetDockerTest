using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DockerTutorialConsole.Extensions
{
    internal static class Dependencies
    {
        internal static IServiceCollection ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            return services;
        }
    }
}
