using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ProSoft.DMT.Web.Infrastructure;

public static class DependencyResolver
{
    public static IServiceCollection AddProSoftDockerManagementToolsWeb(this IServiceCollection services)
    {
        return services;
    }

    public static IHost UseProSoftDockerManagementToolsWeb(this IHost host, ILogger logger)
    {
        return host;
    }
}
