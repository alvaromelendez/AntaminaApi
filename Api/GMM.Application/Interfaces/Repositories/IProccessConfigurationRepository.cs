using GMM.Domain.Entities;

namespace GMM.Application.Interfaces.Repositories
{
    public interface IProccessConfigurationRepository : IBaseRepository<ProccessConfiguration>
    {
        Task<List<ProccessConfiguration>> FindAll(CancellationToken cancellationToken = default);

        Task<List<ProccessConfiguration>> FindIdProccess(int IdProccess, CancellationToken cancellationToken = default);
    }
}
