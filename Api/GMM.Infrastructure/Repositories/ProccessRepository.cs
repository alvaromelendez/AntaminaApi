using GMM.Application.Interfaces.Repositories;
using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GMM.Infrastructure.Repositories
{
    public class ProccessRepository : IProccessRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProccessRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<int> Create(Proccess entity, CancellationToken cancellationToken = default)
        {
            _unitOfWork.Proccess.Create(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> Delete(Proccess entity, CancellationToken cancellationToken = default)
        {
            await _unitOfWork.Proccess.DeleteAsync(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Proccess>> FindAll(CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.Proccess.Queryable().ToListAsync(cancellationToken);
        }

        public async Task<int> Update(Proccess entity, CancellationToken cancellationToken = default)
        {
            _unitOfWork.Proccess.Update(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
