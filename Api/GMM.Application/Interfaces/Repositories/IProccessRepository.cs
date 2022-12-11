using GMM.Domain.Entities;

namespace GMM.Application.Interfaces.Repositories
{
    public interface IProccessRepository : IBaseRepository<Proccess>
    {
        Task<List<Proccess>> FindAll(CancellationToken cancellationToken = default);
    }
}
