using Repository.Interfaces;
using DATA.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly BookDbContext _bookDbContext;
        private readonly DbSet<TEntity> _entities;
        public GenericRepository(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
            _entities = _bookDbContext.Set<TEntity>();
        }
        public async Task Create(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task Update(TEntity entity)
        {
            _entities.Update(entity);
        }
    }
}
