using ProSoft.DMT.Exceptions;

namespace ProSoft.DMT.Api.Data.MsSql;

public static class DatabaseConfig
{
	public static string ConnectionString => Environment.GetEnvironmentVariable(EnvVariableNames.MsSqlConnectionString)
	                                         ??
#if DEBUG

														  "Server=10.215.10.12;Database=prosoft-dmt-dev;User Id=sa;Password=Develop#2022;Encrypt=False";
#else
                                            throw new EnvironmentVariableNotFoundException(EnvVariableNames.MsSqlConnectionString);
#endif
}