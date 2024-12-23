using Docker.DotNet.Models;

namespace ProSoft.DMT.Api.Logic.Contracts.Manager;

public interface IImageManager : IDisposable
{
    Task<List<ImagesListResponse>> GetAllImagesAsync(CancellationToken cancellationToken);
}