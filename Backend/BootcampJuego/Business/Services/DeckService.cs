using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.Implements;
using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Entity.DTOs.Implements.Variants;
using Mapster;
using MapsterMapper;

namespace Business.Services
{
    public class DeckService : BusinesGeneric<DeckCreateDto, DeckSelectDto, Deck>, IDeckService
    {
        private readonly IDeckRepository _deckRepository;
        public DeckService(IData<Deck> data, IMapper mapper, IDeckRepository deckRepository) : base(data, mapper)
        {
            _deckRepository = deckRepository;
        }

        public async Task<List<DeckSelectDto>> GetDeckWithPlayeraAsync(int idplayer)
        {
            try
            {
                var entities = await _deckRepository.GetDeckWithPlayerByAsync(idplayer);
                return entities.Adapt<List<DeckSelectDto>>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar", ex);
            }
        }

        public async Task<bool> DeleteAll()
        {
            try
            {
                var result = await _deckRepository.DeleteAll();
                return result;

            }catch (Exception ex)
            {
                throw new Exception("Erro al borrar todos los deck", ex);
            }
        }
    }
}
