using GMM.Application.Interfaces.Repositories;
using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Infrastructure.Repositories
{
    public class PriorityRepository : IPriorityRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public PriorityRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Task<int> Create(Priority entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Priority entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Priority>> FindAll(CancellationToken cancellationToken = default)
        {
            var response = await _unitOfWork.Prioritys.Queryable().ToListAsync(cancellationToken);
            return response;
        }

        public Task<int> Update(Priority entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
