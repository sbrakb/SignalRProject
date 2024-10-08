using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Contexts;

namespace SignalR.DataAccessLayer.Repositories
{
    public class EfRepositoryBase<TEntity> : IAsyncRepository<TEntity> where TEntity : class
    {
        private readonly SignalRContext _context;

        public EfRepositoryBase(SignalRContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> GetListAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
