using Docker.DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using ProSoft.DMT.Api.Logic.Contracts.Manager;

namespace ProSoft.DMT.Api.Controllers.Docker;

[Route("docker/images")]
[ApiController]
[Produces("application/json")]
public class ImageController : ControllerBase
{
    private readonly ILogger<ImageController> _logger;
    private readonly IImageManager _imageManager;
    private readonly IDockerHubManager _dockerHubManager;

    public ImageController(ILogger<ImageController> logger, IImageManager imageManager, IDockerHubManager dockerHubManager)
    {
        _logger = logger;
        _imageManager = imageManager;
        _dockerHubManager = dockerHubManager;

        if (_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.LogDebug("ImageController initialized successfully.");
        }
    }

    [HttpGet("")]
    public async Task<IEnumerable<ImagesListResponse>> GetAllImagesAsync(CancellationToken cancellationToken)
    {
        _logger.LogDebug("Get all images");
        var imageList = await _imageManager.GetAllImagesAsync(cancellationToken);
        await _dockerHubManager.GetDataAsync(cancellationToken);

        return imageList;
    }
}
