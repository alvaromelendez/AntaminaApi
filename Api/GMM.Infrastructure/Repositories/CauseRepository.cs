using GMM.Application.Interfaces.Repositories;
using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GMM.Infrastructure.Repositories
{
    public class CauseRepository : ICauseRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public CauseRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Task<int> Create(Cause entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Cause entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cause>> FindAll(CancellationToken cancellationToken = default)
        {
            var response = await _unitOfWork.Causes.Queryable().ToListAsync(cancellationToken);
            return response;
        }

        public Task<int> Update(Cause entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
