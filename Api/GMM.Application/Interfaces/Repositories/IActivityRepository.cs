using GMM.Domain.Entities;

namespace GMM.Application.Interfaces.Repositories
{
    public interface IActivityRepository : IBaseRepository<Activity>
    {
        /// <summary>
        /// Busca todos los rigistros.
        /// </summary>
        /// <returns></returns> 
        Task<List<Activity>> FindAll(CancellationToken cancellationToken = default);
    }
}
