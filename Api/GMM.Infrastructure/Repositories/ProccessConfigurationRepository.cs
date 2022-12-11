using GMM.Application.Interfaces.Repositories;
using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GMM.Infrastructure.Repositories
{
    public class ProccessConfigurationRepository : IProccessConfigurationRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProccessConfigurationRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<int> Create(ProccessConfiguration entity, CancellationToken cancellationToken = default)
        {
            _unitOfWork.ProccessConfigurations.Create(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> Delete(ProccessConfiguration entity, CancellationToken cancellationToken = default)
        {
            await _unitOfWork.ProccessConfigurations.DeleteAsync(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<ProccessConfiguration>> FindAll(CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.ProccessConfigurations.Queryable().ToListAsync(cancellationToken);
        }

        public async Task<List<ProccessConfiguration>> FindIdProccess(int IdProccess, CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.ProccessConfigurations.Queryable().Where(x => x.IdProccess == IdProccess).ToListAsync(cancellationToken);
        }

        public async Task<int> Update(ProccessConfiguration entity, CancellationToken cancellationToken = default)
        {
            _unitOfWork.ProccessConfigurations.Update(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
