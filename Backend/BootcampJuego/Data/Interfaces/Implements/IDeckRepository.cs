using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces.Implements
{
    public interface IDeckRepository : IData<Deck>
    {
        Task AddRangeAsync(IEnumerable<Deck> decks);
        Task<List<Deck>> GetDecksBygameWithCardAndPlayer(int gameId);
        Task<bool> DeleteAll();
        Task<List<Deck>> GetDeckWithPlayerByAsync(int playerId);
    }
}
