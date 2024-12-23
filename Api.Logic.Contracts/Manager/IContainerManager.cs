using Docker.DotNet.Models;

namespace ProSoft.DMT.Api.Logic.Contracts.Manager;

public interface IContainerManager : IDisposable
{
    Task<List<ContainerListResponse>> GetContainersAsync(CancellationToken cancellationToken);
}