using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces.Implements;
using Data.Repository;
using Entity.Domain.Models.Implements;
using Entity.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Data.Services
{
    public class GamePlayerRepository : DataGeneric<GamePlayer>, IGamePlayerRepository
    {
        public GamePlayerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<GamePlayer>> GetByGameIdAsync(int gameId)
        {
            return await _context.GamePlayers
                .Where(gp => gp.GameId == gameId)
                .ToListAsync();
        }
    }
}
