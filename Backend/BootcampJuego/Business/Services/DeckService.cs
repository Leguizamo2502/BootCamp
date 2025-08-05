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

        public async Task<DeckSelectDto> GetDeckWithPlayeraAsync(int playerId)
        {
            try
            {
                var decks = await _deckRepository.GetDecksWithPlayerByAsync(playerId);

                if (decks == null || decks.Count == 0)
                    throw new Exception("No se encontraron decks");

                return decks.Adapt<DeckSelectDto>();
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

        public async Task<bool> DeleteUsed(int playerId, int cardId)
        {
            try
            {
                var result = await _deckRepository.DeleteUsed(playerId, cardId);
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro al borrar todos los deck", ex);
            }
        }
    }
}
