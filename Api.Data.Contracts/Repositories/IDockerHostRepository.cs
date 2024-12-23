using ProSoft.DMT.Contracts.Models;

namespace ProSoft.DMT.Api.Data.Contracts.Repositories;

public interface IDockerHostRepository : IDisposable
{
	IQueryable<DockerHost> GetDockerHostQuery();
}