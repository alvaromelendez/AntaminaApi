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
    public class SymptomFaultRepository : ISymptomFaultRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public SymptomFaultRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Task<int> Create(SymptomFault entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(SymptomFault entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SymptomFault>> FindAll(CancellationToken cancellationToken = default)
        {
            var response = await _unitOfWork.SymptomFaults.Queryable().ToListAsync(cancellationToken);
            return response;
        }

        public Task<int> Update(SymptomFault entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
