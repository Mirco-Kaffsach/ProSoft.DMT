namespace ProSoft.DMT.Api.Logic.Contracts.Manager;

public interface IDockerHubManager : IDisposable
{
    Task GetDataAsync(CancellationToken cancellationToken);
}