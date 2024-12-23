using Microsoft.EntityFrameworkCore;
using ProSoft.DMT.Api.Data.MsSql.EntityConfigs;
using ProSoft.DMT.Contracts.Models;

namespace ProSoft.DMT.Api.Data.MsSql;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public AppDbContext() { }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<DockerHost>().ConfigureEntity();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder
				.UseSqlServer(DatabaseConfig.ConnectionString)
				.EnableDetailedErrors()
				;
		}
	}
}