using Data.Interfaces.Implements;
using Data.Repository;
using Entity.Domain.Models.Implements;
using Entity.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Data.Services
{
    public class PlayerRepository : DataGeneric<Player>, IPlayerRepository
    {
        private readonly IGamePlayerRepository _gamePlayerRepository;

        public PlayerRepository(ApplicationDbContext context, IGamePlayerRepository gamePlayerRepository)
            : base(context)
        {
            _gamePlayerRepository = gamePlayerRepository;
        }

        public override async Task<Player> CreateAsync(Player entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            var relation = new GamePlayer
            {
                GameId = 1,
                PlayerId = entity.Id
            };

            _context.Add(relation);
            await _context.SaveChangesAsync();

            return entity;
        }

        public override async Task<IEnumerable<Player>> GetAllAsync()
        {
            return await _dbSet.Where(p => p.Active).ToListAsync();
        }

        public async Task<IEnumerable<Player>> GetAllDeletes()
        {
            return await _dbSet.Where(p => !p.Active).ToListAsync();
        }

        public async Task<int?> DeleteLogic(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return null;

            entity.Active = false;
            _dbSet.Update(entity);

            var relation = await _context.GamePlayers.FirstOrDefaultAsync(p => p.PlayerId == id);
            if (relation != null)
            {
                _context.GamePlayers.Remove(relation);
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int?> RestoreLogic(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return null;

            entity.Active = true;
            _dbSet.Update(entity);

            var relation = new GamePlayer
            {
                GameId = 1,
                PlayerId = entity.Id
            };

            _context.Add(relation);




            return await _context.SaveChangesAsync();
        }
    }
}
