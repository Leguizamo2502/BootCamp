using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;

namespace Data.Interfaces.Implements
{
    public interface IPlayerRepository : IData<Player>
    {
        Task<int?> DeleteLogic(int id);
        Task<int?> RestoreLogic(int id);

        Task<IEnumerable<Player>> GetAllDeletes();
    }
}
