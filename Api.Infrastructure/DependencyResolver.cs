using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProSoft.DMT.Api.Logic.Infrastructure;
using ProSoft.DMT.Contracts;

namespace ProSoft.DMT.Api.Infrastructure;

public static class DependencyResolver
{
	public static IServiceCollection AddProSoftDockerManagementToolsApi(this IServiceCollection services, DatabaseEngine dbEngine)
	{
		services
			.AddProSoftDockerManagementToolsCore(dbEngine)
			;

		return services;
	}

	public static IHost UseProSoftDockerManagementToolsApi(this IHost host, ILogger logger, DatabaseEngine dbEngine)
	{
		logger.LogInformation("Configuring dependencies for: ProSoft.DMT.Api");

		host
			.UseProSoftDockerManagementToolsCore(logger, dbEngine)
			;

		return host;
	}
}