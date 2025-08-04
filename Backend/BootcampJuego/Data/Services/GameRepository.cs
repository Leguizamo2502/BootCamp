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
    public class GameRepository : DataGeneric<Game>, IGameRepository
    {
        public GameRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Game?> GetWithPlayersAsync(int gameid)
        {
            return await _context.Set<Game>()
                .Include(r => r.GamePlayers)
                    .ThenInclude(gp => gp.Player)
                .FirstOrDefaultAsync(r => r.Id == gameid);
        }


        



    }
}
