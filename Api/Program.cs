using ProSoft.DMT.Api.Infrastructure;
using ProSoft.DMT.Contracts;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
// Configure Logging
builder.Host.UseSerilog
(
	(hostingContext, logConfig) => logConfig.ReadFrom.Configuration(hostingContext.Configuration)
);

// Add services to the container.
builder.Services.AddProSoftDockerManagementToolsApi(DatabaseEngine.MsSql);
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILogger<Program>>();
app.UseProSoftDockerManagementToolsApi(logger, DatabaseEngine.MsSql);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

logger.LogInformation("ProSoft.DMT.Api is ready for requests");

await app.RunAsync();
