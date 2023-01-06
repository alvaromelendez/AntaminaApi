using GMM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Interfaces.Repositories
{
    public interface IFaultRepository : IBaseRepository<Fault>
    {
        /// <summary>
        /// Busca todos los rigistros.
        /// </summary>
        /// <returns></returns> 
        Task<List<Fault>> FindAll(CancellationToken cancellationToken = default);
    }
}
