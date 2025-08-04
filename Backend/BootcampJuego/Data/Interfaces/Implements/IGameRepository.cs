using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;

namespace Data.Interfaces.Implements
{
    public interface IGameRepository : IData<Game>
    {
        Task<Game?> GetWithPlayersAsync(int gameid);

    }
}
