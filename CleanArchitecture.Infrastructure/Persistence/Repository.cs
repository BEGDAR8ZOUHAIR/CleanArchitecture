using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private ApplicationDbContext _context = null;
        private DbSet<TEntity> _entity = null;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }
        
        // Function to add new entity

        public  async ValueTask<TEntity> AddAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            return entity;
                

        }

        // Function to read entity by id
        public async ValueTask<TEntity> Read(string entityId)
        {
            return await  _entity.FindAsync(entityId);
        }

        // Function to read all entities
        public async ValueTask<IEnumerable<TEntity>> ReadAll()
        {
            return await _entity.ToListAsync();
        }

        // Function to update entity
        public void UpdateAsync(TEntity entity)
        {
              _entity.Attach(entity);
        }

        // Function to delete entity 
        public async ValueTask<TEntity> DeleteAsync(string entityId) 
        {
            
        }
    }

}
