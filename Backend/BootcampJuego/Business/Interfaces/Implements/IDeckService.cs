using Business.Interfaces.Repository;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;

namespace Business.Interfaces.Implements
{
    public interface IDeckService : IBusinessGeneric<DeckCreateDto,DeckSelectDto>
    {
        Task<bool> DeleteAll();
    }
}
