using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProSoft.DMT.Api.Logic.Contracts.Manager;
using ProSoft.DMT.Contracts.Models;

namespace ProSoft.DMT.Api.Controllers;

[Route("dockerhosts")]
[ApiController]
[Produces("application/json")]
public sealed class DockerHostController : ControllerBase
{
    private readonly ILogger<DockerHostController> _logger;
    private readonly IDockerHostManager _dockerHostManager;

    public DockerHostController(ILogger<DockerHostController> logger, IDockerHostManager dockerHostManager)
    {
        _logger = logger;
        _dockerHostManager = dockerHostManager;

        if (_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.LogDebug("DockerHostController initialized successfully.");
        }
    }

    [HttpGet("")]
    public async IAsyncEnumerable<DockerHost> GetAllDockerHostsAsync([EnumeratorCancellation] CancellationToken cancellationToken)
    {
        _logger.LogDebug("Get all docker hosts");
        var query = _dockerHostManager.GetAllDockerHosts();

        await foreach (var resultItem in query.AsAsyncEnumerable().WithCancellation(cancellationToken))
        {
            yield return resultItem;
        }
    }
}
