using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Entity.DTOs.Implements.Variants;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class GameController : BaseController<GameCreateDto, GameSelectDto, IGameService>
    {
        private readonly IDeckService _deckService;
        public GameController(IGameService service, ILogger<GameController> logger, IDeckService deckService) : base(service, logger)
        {
            _deckService = deckService;
        }

        protected override async Task AddAsync(GameCreateDto dto)
        {
            await _service.CreateAsync(dto);
        }

        protected override async Task<bool> DeleteAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }

        protected override async Task<IEnumerable<GameSelectDto>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        protected override async Task<GameSelectDto?> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        protected override async Task<bool> UpdateAsync(int id, GameCreateDto dto)
        {
            return await _service.UpdateAsync(dto);
        }

        [HttpPost("{gameId}/start")]
        public async Task<ActionResult<GameStartResultDto>> StartGame(int gameId)
        {
            try
            {
                var result = await _service.StartGameAsync(gameId);

                if (!result.Success)
                    return BadRequest("No se pudo iniciar la partida.");

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log de error, si aplica
                return StatusCode(500, $"Error al iniciar la partida: {ex.Message}");
            }
        }

        [HttpDelete("/end")]
        public async Task<ActionResult<GameStartResultDto>> DeleteAll()
        {
            try
            {
                var result = await _deckService.DeleteAll();

                if (!result)
                    return BadRequest("Error al borrar decks.");

                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log de error, si aplica
                return StatusCode(500, $"Error al borrar decks: {ex.Message}");
            }
        }
    }
}
