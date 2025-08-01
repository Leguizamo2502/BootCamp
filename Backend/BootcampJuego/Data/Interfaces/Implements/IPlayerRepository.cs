using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;

namespace Data.Interfaces.Implements
{
    public interface IPlayerRepository : IData<Player>
    {
    }
}
