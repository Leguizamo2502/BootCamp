using Data.Interfaces.Implements;
using Data.Repository;
using Entity.Domain.Models.Implements;
using Entity.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Data.Services
{
    public class PlayerRepository : DataGeneric<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Player>> GetAllAsync()
        {
            return await _dbSet.Where(p=>p.Active == true).ToListAsync();
        }
        public async Task<IEnumerable<Player>> GetAllDeletes()
        {
            return await _dbSet.Where(p=> p.Active == false).ToListAsync();
        }

        public async Task<int?> DeleteLogic(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return null;
            entity.Active = false;
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync();

        }

        public async Task<int?> RestoreLogic(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return null;
            entity.Active = true;
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
