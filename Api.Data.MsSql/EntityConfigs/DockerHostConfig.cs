using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSoft.DMT.Contracts.Models;

namespace ProSoft.DMT.Api.Data.MsSql.EntityConfigs;

internal static class DockerHostConfig
{
	private static readonly string SchemaName = "data";
	private static readonly string TableName = "DockerHosts";

	internal static EntityTypeBuilder ConfigureEntity(this EntityTypeBuilder<DockerHost> entityTypeBuilder)
	{
		entityTypeBuilder
			.ConfigureTable()
			.ConfigureColumns()
			.ConfigureIndices()
			.ConfigureRelations()
			;

		return entityTypeBuilder;
	}


	private static EntityTypeBuilder<DockerHost> ConfigureTable(this EntityTypeBuilder<DockerHost> entityTypeBuilder)
	{
		entityTypeBuilder
			.ToTable(TableName, SchemaName)
			.HasKey(pk => pk.Id);

		return entityTypeBuilder;
	}

	private static EntityTypeBuilder<DockerHost> ConfigureColumns(this EntityTypeBuilder<DockerHost> entityTypeBuilder)
	{
		entityTypeBuilder.Property(p => p.SystemId)
		                 .HasColumnName("SystemId")
		                 .HasColumnType("UNIQUEIDENTIFIER")
		                 .IsRequired();
		
		entityTypeBuilder.Property(p => p.Id)
		                 .HasColumnName("Id")
		                 .HasColumnType("INT")
		                 .ValueGeneratedOnAdd();

		entityTypeBuilder.Property(p => p.Title)
		                 .HasColumnName("Title")
		                 .HasColumnType("VARCHAR(128)")
		                 .HasMaxLength(128)
		                 .IsRequired();
		
		entityTypeBuilder.Property(p => p.FqdnIp)
		                 .HasColumnName("FqdnIp")
		                 .HasColumnType("VARCHAR(128)")
		                 .HasMaxLength(128)
		                 .IsRequired();
		
		entityTypeBuilder.Property(p => p.IsActive)
		                 .HasColumnName("IsActive")
		                 .HasColumnType("BIT")
		                 .HasDefaultValue(true)
		                 .IsRequired();
		
		entityTypeBuilder.Property(p => p.Created)
		                 .HasColumnName("Created")
		                 .HasColumnType("DATETIME")
		                 .HasDefaultValueSql("GETDATE()");

		return entityTypeBuilder;
	}

	private static EntityTypeBuilder<DockerHost> ConfigureIndices(this EntityTypeBuilder<DockerHost> entityTypeBuilder)
	{
		entityTypeBuilder
			.HasIndex(i => i.SystemId, $"UIX_{SchemaName}_{TableName}_SystemId")
			.IsUnique();

		return entityTypeBuilder;
	}

	private static EntityTypeBuilder<DockerHost> ConfigureRelations(this EntityTypeBuilder<DockerHost> entityTypeBuilder)
	{

		return entityTypeBuilder;
	}
}
