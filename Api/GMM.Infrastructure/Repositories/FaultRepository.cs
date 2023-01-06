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
    public class FaultRepository : IFaultRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public FaultRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public Task<int> Create(Fault entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public Task<int> Delete(Fault entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Fault>> FindAll(CancellationToken cancellationToken = default)
        {
            var response = await _unitOfWork.Faults.Queryable().ToListAsync(cancellationToken);
            return response;
        }
        public Task<int> Update(Fault entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
