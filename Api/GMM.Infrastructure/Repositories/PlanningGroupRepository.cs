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
    internal class PlanningGroupRepository: IPlanningGroupRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlanningGroupRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Task<int> Create(PlanningGroup entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(PlanningGroup entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PlanningGroup>> FindAll(CancellationToken cancellationToken = default)
        {
            var response = await _unitOfWork.PlanningGroups.Queryable().ToListAsync(cancellationToken);
            return response;
        }

        public Task<int> Update(PlanningGroup entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
