using GMM.Domain.Entities;

namespace GMM.Application.Interfaces.Repositories
{
    public interface IPriorityRepository : IBaseRepository<Priority>
    {
        /// <summary>
        /// Busca todos los rigistros.
        /// </summary>
        /// <returns></returns> 
        Task<List<Priority>> FindAll(CancellationToken cancellationToken = default);
    }
}
