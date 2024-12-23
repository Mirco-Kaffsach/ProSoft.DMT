using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProSoft.DMT.Api.Data.MsSql.Dependencies;
using ProSoft.DMT.Contracts;

namespace ProSoft.DMT.Api.Data.Infrastructure;

public static class DependencyResolver
{
	public static IServiceCollection AddProSoftDockerManagementToolsData(this IServiceCollection services, DatabaseEngine dbEngine)
	{
		switch (dbEngine)
		{
			case DatabaseEngine.Postgres:
				break;

			case DatabaseEngine.MsSql:
				services.AddMsSqlDatabase();
				break;
		}

		return services;
	}

	public static IHost UseProSoftDockerManagementToolsData(this IHost host, ILogger logger, DatabaseEngine dbEngine)
	{
		logger.LogInformation("Configuring dependencies for: ProSoft.DMT.Data");

		switch (dbEngine)
		{
			case DatabaseEngine.Postgres:
				break;

			case DatabaseEngine.MsSql:
				host.UseMsSqlDatabase(logger);
				break;
		}

		return host;
	}
}