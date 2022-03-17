using DockerTutorialConsole.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, builder) =>
    {
        builder
            .AddEnvironmentVariables()
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json");
    })
    .ConfigureServices((context, services) =>
    {
        Dependencies.ConfigureServices(context.Configuration, services);
    })
    .Build();

// Application code should start here.

await host.RunAsync();