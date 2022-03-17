using DocketTutorialServices.Services;
using DocketTutorialServices.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DockerTutorialConsole.Extensions
{
    internal static class Dependencies
    {
        internal static IServiceCollection ConfigureServices(IConfiguration configuration, IServiceCollection services)
            => services
                .AddScoped<ImageService>()
                .AddScoped<StorageService>()
                .AddScoped<IDbConnection, DbConnection>()
                .AddScoped<MongoUserData>()
                .AddScoped<MainService>();
    }
}
