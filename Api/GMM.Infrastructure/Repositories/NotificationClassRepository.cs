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
    public class NotificationClassRepository : INotificationClassRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationClassRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public Task<int> Create(NotificationClass entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public Task<int> Delete(NotificationClass entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public async Task<List<NotificationClass>> FindAll(CancellationToken cancellationToken = default)
        {
            var response = await _unitOfWork.NotificationClass.Queryable().ToListAsync(cancellationToken);
            return response;
        }
        public Task<int> Update(NotificationClass entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
