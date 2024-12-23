using ProSoft.DMT.Web.Components;
using ProSoft.DMT.Web.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
       .AddProSoftDockerManagementToolsWeb()
       .AddRazorComponents()
       .AddInteractiveServerComponents();

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILogger<Program>>();
app.UseProSoftDockerManagementToolsWeb(logger);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

await app.RunAsync();
