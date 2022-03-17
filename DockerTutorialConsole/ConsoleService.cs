using DocketTutorialServices.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DockerTutorialConsole
{
    public class ConsoleService : IHostedService
    {
        private readonly MainService _mainService;

        public ConsoleService(IServiceScopeFactory factory)
        {
            _mainService = factory.CreateScope().ServiceProvider.GetRequiredService<MainService>();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _mainService.RunAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
