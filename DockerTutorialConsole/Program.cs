using DockerTutorialConsole;
using DockerTutorialConsole.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, builder) =>
    {
        builder
            .AddEnvironmentVariables()
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json");
    })
    .ConfigureServices((context, services) =>
    {
        services.AddHostedService<ConsoleService>();
        Dependencies.ConfigureServices(context.Configuration, services);
    })
    .Build()
    .RunAsync();
