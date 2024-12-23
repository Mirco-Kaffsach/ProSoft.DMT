using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProSoft.DMT.Api.Data.Contracts.Repositories;
using ProSoft.DMT.Api.Data.MsSql.Repositories;

namespace ProSoft.DMT.Api.Data.MsSql.Dependencies;

public static class DependencyResolver
{
	public static IServiceCollection AddMsSqlDatabase(this IServiceCollection services)
	{
		services
			.AddDbContext<AppDbContext>(context => context.UseSqlServer(DatabaseConfig.ConnectionString))
			.AddScoped<IDockerHostRepository, DockerHostRepository>()
			.AddScoped<IContainerRepository, ContainerRepository>()
			.AddScoped<IImageRepository, ImageRepository>()
			.AddScoped<INetworkRepository, NetworkRepository>()
			.AddScoped<IStackRepository, StackRepository>()
			.AddScoped<IVolumeRepository, VolumeRepository>()
			;

		return services;
	}

	public static IHost UseMsSqlDatabase(this IHost host, ILogger logger)
	{
		logger.LogInformation("Using MSSQL as database.");

		MigrationHelper.Migrate<AppDbContext>(host);

		return host;
	}
}
