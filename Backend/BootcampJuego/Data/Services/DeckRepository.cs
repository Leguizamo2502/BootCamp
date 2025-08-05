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
        private readonly IPlayerRepository _playerRepository;
        public DeckRepository(ApplicationDbContext context, IPlayerRepository playerRepository) : base(context)
        {
            _playerRepository = playerRepository;
        }

        public async Task<bool> DeleteUsed(int playerId, int cardId)
        {
            var deck = await _dbSet
                .FirstOrDefaultAsync(d => d.GamePlayerId == playerId && d.CardId == cardId);

            if (deck == null) return false;

            _context.Remove(deck);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Deck>> GetDecksWithPlayerByAsync(int playerId)
        {
            return await _dbSet
                .Include(d => d.Card)
                .Include(d => d.GamePlayer)
                    .ThenInclude(gp => gp.Player)
                .Where(d => d.GamePlayer.PlayerId == playerId)
                .ToListAsync();
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
