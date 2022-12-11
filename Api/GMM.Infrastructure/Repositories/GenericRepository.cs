using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Domain;
using GMM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;


namespace GMM.Infrastructure.Repositories
{
    /// <summary>
    /// Implementa operaciones basicas de una entidad.
    /// </summary>
    /// <typeparam name="TEntity">Entidad que se encuentra asociada a la BD.</typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
                              where TEntity : class, IGenerateEntity<TEntity>
                              

    {

        private readonly BaseDbContext _context;
        private readonly IMapper _mapper;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(BaseDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
            this._dbSet = context.Set<TEntity>();
        }


        public void Create(TEntity entity)
        {            
            _dbSet.Add(entity);
        }


        public void CreateRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                this.Create(entity);
        }


        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }




        public TEntity Find(params object[] keyValues)
        {
            return _dbSet.Find(keyValues);
        }


        public async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await _dbSet.FindAsync(keyValues);
        }



        public EntityEntry<TEntity> Update(TEntity entity)
        {
            TEntity destination = entity.RecoverKey();
            _dbSet.Attach(destination);
            _context.Entry(destination).State = EntityState.Unchanged;
            _mapper.Map(entity, destination);
            var entry = _context.Entry(destination);
            return entry;
        }




        public void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity);

            _dbSet.Remove(entity);
        }


        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                this.Delete(entity);
        }


        public void Delete(params object[] id)
        {
            TEntity entity = this.Find(id);
            if (entity != null)
                this.Delete(entity);
        }


        public async Task DeleteAsync(params object[] id)
        {
            TEntity entity = await this.FindAsync(id);
            if (entity != null)
                this.Delete(entity);
        }



        public virtual IQueryable<TEntity> Query(string query, params object[] parameters)
        {
            return _dbSet.FromSqlRaw(query, parameters).AsQueryable();
        }


        public virtual IQueryable<TEntity> QueryAsNoTracking(string query, params object[] parameters)
        {
            return _dbSet.FromSqlRaw(query, parameters).AsNoTracking();
        }


        public IQueryable<TEntity> Queryable()
        {
            return _dbSet.AsQueryable();
        }


        public IQueryable<TEntity> AsNoTracking()
        {
            return _dbSet.AsNoTracking();
        }


    }
}
