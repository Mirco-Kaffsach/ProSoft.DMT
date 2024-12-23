using ProSoft.DMT.Contracts.Models;

namespace ProSoft.DMT.Api.Logic.Contracts.Manager;

public interface IDockerHostManager : IDisposable
{
    IQueryable<DockerHost> GetAllDockerHosts();
}
