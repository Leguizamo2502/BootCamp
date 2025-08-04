using Data.Interfaces.Implements;
using Data.Repository;
using Entity.Domain.Models.Implements;
using Entity.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class DeckRepository : DataGeneric<Deck>, IDeckRepository
    {
        public DeckRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task AddRangeAsync(IEnumerable<Deck> decks)
        {
            await _context.Deck.AddRangeAsync(decks);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Deck>> GetDecksBygameWithCardAndPlayer(int gameId)
        {
            return await _context.Deck
                .Include(d => d.Card)
                .Include(d => d.GamePlayer)
                    .ThenInclude(gp => gp.Player)
                .Where(d => d.GamePlayer.GameId == gameId)
                .ToListAsync();
        }

        public async Task<bool> DeleteAll()
        {
            var allEntities = await _dbSet.ToListAsync();
            _dbSet.RemoveRange(allEntities);
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
