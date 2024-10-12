namespace SignalRWebUI.DataAccessLayer.Repositories;

public interface IAsyncRepository<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> GetAsync(int id);
    Task<List<TEntity>> GetListAsync();
}
