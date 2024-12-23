using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProSoft.DMT.Api.Data.Infrastructure;
using ProSoft.DMT.Api.Logic.Contracts.Manager;
using ProSoft.DMT.Api.Logic.Manager;
using ProSoft.DMT.Contracts;

namespace ProSoft.DMT.Api.Logic.Infrastructure;

public static class DependencyResolver
{
	public static IServiceCollection AddProSoftDockerManagementToolsCore(this IServiceCollection services, DatabaseEngine dbEngine)
	{
		services.AddHttpClient(HttpClientNames.DockerHub, (serviceProvider, client) =>
		{
			client.BaseAddress = new Uri("https://registry.hub.docker.com/v2/repositories/");
		});

		services
			.AddProSoftDockerManagementToolsData(dbEngine)
			.AddScoped<IDockerHostManager, DockerHostManager>()
			.AddScoped<IContainerManager, ContainerManager>()
			.AddScoped<IImageManager, ImageManager>()
			.AddScoped<IDockerHubManager, DockerHubManager>()
			;

		return services;
	}

	public static IHost UseProSoftDockerManagementToolsCore(this IHost host, ILogger logger, DatabaseEngine dbEngine)
	{
		logger.LogInformation("Configuring dependencies for: ProSoft.DMT.Core");

		host
			.UseProSoftDockerManagementToolsData(logger, dbEngine)
			;

		return host;
	}
}