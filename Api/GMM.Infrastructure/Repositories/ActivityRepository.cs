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
    public class ActivityRepository : IActivityRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActivityRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Task<int> Create(Activity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Activity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Activity>> FindAll(CancellationToken cancellationToken = default)
        {
            var response = await _unitOfWork.Activities.Queryable().ToListAsync(cancellationToken);
            return response;
        }

        public Task<int> Update(Activity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
