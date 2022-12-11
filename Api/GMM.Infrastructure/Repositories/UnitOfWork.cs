using System;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Domain.Entities;
using GMM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace GMM.Infrastructure.Repositories
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {

        private readonly BaseDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private bool disposedValue;

        public UnitOfWork(BaseDbContext Context, IServiceProvider serviceProvider)
        {
            this._context = Context;
            this._serviceProvider = serviceProvider;
        }


        #region Entidades mapeadas al contexto

        public IGenericRepository<Fault> Faults =>
            this._serviceProvider.GetRequiredService<IGenericRepository<Fault>>();

        public IGenericRepository<Activity> Activities =>
           this._serviceProvider.GetRequiredService<IGenericRepository<Activity>>();

        public IGenericRepository<Document> Documents =>
           this._serviceProvider.GetRequiredService<IGenericRepository<Document>>();

        public IGenericRepository<Notification> Notifications =>
          this._serviceProvider.GetRequiredService<IGenericRepository<Notification>>();

        public IGenericRepository<WorkOrder> WorkOrder =>
          this._serviceProvider.GetRequiredService<IGenericRepository<WorkOrder>>();

        public IGenericRepository<UploadFile> UploadFiles =>
            this._serviceProvider.GetRequiredService<IGenericRepository<UploadFile>>();

        public IGenericRepository<MasterTable> MasterTables =>
              this._serviceProvider.GetRequiredService<IGenericRepository<MasterTable>>();

        public IGenericRepository<Person> Persons =>
             this._serviceProvider.GetRequiredService<IGenericRepository<Person>>();


        public IGenericRepository<PersonFile> PersonFiles =>
              this._serviceProvider.GetRequiredService<IGenericRepository<PersonFile>>();

        public IGenericRepository<AttachedFile> AttachedFiles =>
              this._serviceProvider.GetRequiredService<IGenericRepository<AttachedFile>>();

        public IGenericRepository<Proccess> Proccess =>
            this._serviceProvider.GetRequiredService<IGenericRepository<Proccess>>();

        public IGenericRepository<ProccessConfiguration> ProccessConfigurations =>
            this._serviceProvider.GetRequiredService<IGenericRepository<ProccessConfiguration>>();

        #endregion




        #region Funciones y metodos públicos


        public DbTransaction Transaction()
        {
            return _context.Database.BeginTransaction().GetDbTransaction();
        }


        public async Task<DbTransaction> TransactionAsync(CancellationToken cancellationToken = default)
        {
            return (await _context.Database.BeginTransactionAsync(cancellationToken)).GetDbTransaction();
        }


        public void UseTransaction(DbTransaction dbTransaction)
        {
            _context.Database.UseTransaction(dbTransaction);
        }


        public async Task UseTransactionAsync(DbTransaction dbTransaction, CancellationToken cancellationToken = default)
        {
            await _context.Database.UseTransactionAsync(dbTransaction, cancellationToken);
        }


        public int SaveChanges()
        {
            try
            {
                var vResult = this._context.SaveChanges();
                return vResult;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Record does not exist in the database");
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var vResult = await this._context.SaveChangesAsync(cancellationToken);
                return vResult;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Record does not exist in the database");
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                    _context.Dispose();                    
                }
                
                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~UnitOfWork()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion




    }

}
