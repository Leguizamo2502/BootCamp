using Entity.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using Entity.Infrastructure.Contexts;

namespace Data.Repository
{
    public class DataGeneric<T> : ADataGeneric<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public DataGeneric(ApplicationDbContext context)
        {
            _context = context;
            _dbSet= context.Set<T>();
            
        }
        public override async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public override async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(e=> e.Id == id);
        }

        public override async Task<T> CreateAsync(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public override async Task<bool> UpdateAsync(T entity)
        {
            var entityUpdated = await _dbSet.FindAsync(entity.Id);
            if (entityUpdated == null) return false;
            _context.Entry(entityUpdated).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return false;
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        


        

    }
}
