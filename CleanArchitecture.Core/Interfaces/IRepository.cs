


namespace CleanArchitecture.Core.Interfaces
{
    public interface IRepository <TEntity> where TEntity : class
    {
        
         
        ValueTask<TEntity> AddAsync (TEntity entity);

        ValueTask<TEntity> Read (string entityId);

        ValueTask<IEnumerable<TEntity>> ReadAll();

        void  UpdateAsync (TEntity entity);

        ValueTask<TEntity> DeleteAsync (string entityId);

    
    }
}
