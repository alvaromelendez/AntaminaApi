using GMM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Interfaces.Repositories
{
    public interface IMasterTableRepository : IBaseRepository<MasterTable>
    {

        /// <summary>
        /// Busca un registro enviando su key ID.
        /// </summary>
        /// <param name="idMasterTable"></param>
        /// <returns></returns> 
        Task<MasterTable> FindId(string idMasterTable, CancellationToken cancellationToken = default);

        /// <summary>
        /// Busca todos los rigistros.
        /// </summary>
        /// <returns></returns> 
        Task<List<MasterTable>> FindAll(CancellationToken cancellationToken = default);

        /// <summary>
        /// Elimina un registro enviando su key ID.
        /// </summary>
        /// <param name="idMasterTable"></param>
        /// <returns></returns>
        Task<int> Delete(string idMasterTable, CancellationToken cancellationToken = default);


    }

}
