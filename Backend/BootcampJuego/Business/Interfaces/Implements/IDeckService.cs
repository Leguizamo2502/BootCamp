using Business.Interfaces.Repository;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Entity.DTOs.Implements.Variants;

namespace Business.Interfaces.Implements
{
    public interface IDeckService : IBusinessGeneric<DeckCreateDto,DeckSelectDto>
    {
        Task<bool> DeleteAll();
        Task<DeckSelectDto> GetDeckWithPlayeraAsync(int idplayer);
    }
}
