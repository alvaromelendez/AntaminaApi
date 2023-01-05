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
    public class JobPositionRepository : IJobPositionRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobPositionRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public Task<int> Create(JobPosition entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(JobPosition entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<JobPosition>> FindAll(CancellationToken cancellationToken = default)
        {
            var response = await _unitOfWork.JobPositions.Queryable().ToListAsync(cancellationToken);
            return response;
        }

        public Task<int> Update(JobPosition entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
