using Docker.DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using ProSoft.DMT.Api.Logic.Contracts.Manager;

namespace ProSoft.DMT.Api.Controllers.Docker;

[Route("docker/containers")]
[ApiController]
[Produces("application/json")]
public class ContainerController : ControllerBase
{
    private readonly ILogger<ContainerController> _logger;
    private readonly IContainerManager _containerManager;

    public ContainerController(ILogger<ContainerController> logger, IContainerManager containerManager)
    {
        _logger = logger;
        _containerManager = containerManager;

        if (_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.LogDebug("ContainerController initialized successfully.");
        }
    }

    [HttpGet("")]
    public async Task<IEnumerable<ContainerListResponse>> GetContainersAsync(CancellationToken cancellationToken)
    {
        _logger.LogDebug("Get all containers");
        var result = await _containerManager.GetContainersAsync(cancellationToken);

        return result;
    }
}
