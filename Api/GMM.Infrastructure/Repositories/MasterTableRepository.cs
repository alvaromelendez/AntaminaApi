using AutoMapper;
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
    public class MasterTableRepository : IMasterTableRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public MasterTableRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<int> Create(MasterTable entity, CancellationToken cancellationToken = default)
        {
            entity.RecordCreationDate = DateTime.Now;
            _unitOfWork.MasterTables.Create(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> Delete(string idMasterTable, CancellationToken cancellationToken = default)
        {
            await _unitOfWork.MasterTables.DeleteAsync(idMasterTable);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> Delete(MasterTable entity, CancellationToken cancellationToken = default)
        {
            await _unitOfWork.MasterTables.DeleteAsync(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<MasterTable>> FindAll(CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.MasterTables.Queryable().ToListAsync(cancellationToken);
        }

        public async Task<MasterTable> FindId(string idMasterTable, CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.MasterTables.FindAsync(idMasterTable);  
        }

        public async Task<int> Update(MasterTable entity, CancellationToken cancellationToken = default)
        {
            entity.RecordEditDate = DateTime.Now;
            _unitOfWork.MasterTables.Update(entity);
            return await _unitOfWork.SaveChangesAsync(cancellationToken);
        }



    }

}
