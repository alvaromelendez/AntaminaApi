using GMM.Domain.Entities;

namespace GMM.Application.Interfaces.Repositories
{
    public interface ICauseRepository : IBaseRepository<Cause>
    {
        /// <summary>
        /// Busca todos los rigistros.
        /// </summary>
        /// <returns></returns> 
        Task<List<Cause>> FindAll(CancellationToken cancellationToken = default);
    }
}
