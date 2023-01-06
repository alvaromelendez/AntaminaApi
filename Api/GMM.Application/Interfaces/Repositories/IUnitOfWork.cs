using GMM.Domain.Entities;
using System.Data.Common;


namespace GMM.Application.Interfaces.Repositories 
{
    public interface IUnitOfWork
    {
        IGenericRepository<Fault> Faults { get; }
        IGenericRepository<SymptomFault> SymptomFaults { get; }

        IGenericRepository<Activity> Activities { get; }
        IGenericRepository<Cause> Causes { get; }

        IGenericRepository<Document> Documents { get; }

        IGenericRepository<Notification> Notifications { get; }

        IGenericRepository<WorkOrder> WorkOrder { get; }

        IGenericRepository<UploadFile> UploadFiles { get;  }

        IGenericRepository<MasterTable> MasterTables { get; }

        IGenericRepository<NotificationClass> NotificationClass { get; }
        IGenericRepository<JobPosition> JobPositions { get; }
        IGenericRepository<PlanningGroup> PlanningGroups { get; }
        IGenericRepository<Priority> Prioritys { get; }

        IGenericRepository<Person> Persons { get; }
         
        IGenericRepository<PersonFile> PersonFiles { get; }

        IGenericRepository<AttachedFile> AttachedFiles { get; }

        IGenericRepository<Proccess> Proccess { get; }

        IGenericRepository<ProccessConfiguration> ProccessConfigurations { get; }

        /// <summary>
        /// Guarda los cambios realizados del contexto a la Base de Datos
        /// </summary>
        int SaveChanges();

        /// <summary>
        /// Guarda los cambios realizados en forma asíncrona del contexto a la Base de Datos.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Inicia un ambiente de transacción  
        /// </summary>
        /// <returns></returns>
        DbTransaction Transaction();

        /// <summary>
        /// Inicia un ambiente de transacción en asíncrono
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<DbTransaction> TransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adjunta un ambiente de transacción al contexto
        /// </summary>
        /// <param name="dbTransaction"></param>
        void UseTransaction(DbTransaction dbTransaction);

        /// <summary>
        /// Adjunta un ambiente de transacción al contexto en asíncrono.
        /// </summary>
        /// <param name="dbTransaction"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task UseTransactionAsync(DbTransaction dbTransaction, CancellationToken cancellationToken = default);
    }
}