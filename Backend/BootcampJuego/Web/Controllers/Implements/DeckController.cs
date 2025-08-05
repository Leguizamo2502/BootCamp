using Business.Interfaces.Implements;
using Business.Services;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Entity.DTOs.Implements.Variants;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class DeckController : BaseController<DeckCreateDto, DeckSelectDto, IDeckService>
    {
        public DeckController(IDeckService service, ILogger<DeckController> logger) : base(service, logger)
        {
        }

        protected override async Task AddAsync(DeckCreateDto dto)
        {
            await _service.CreateAsync(dto);
        }

        protected override async Task<bool> DeleteAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }

        protected override async Task<IEnumerable<DeckSelectDto>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        protected override async Task<DeckSelectDto?> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        protected override async Task<bool> UpdateAsync(int id, DeckCreateDto dto)
        {
            return await _service.UpdateAsync(dto);
        }

        [HttpGet("player/{id}")]
        //[ProducesResponseType(typeof(IEnumerable<TDto>), 200)]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public virtual async Task<IActionResult> GetDeckPLayer(int id)
        {
            try
            {
                var result = await _service.GetDeckWithPlayeraAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo datos");
                return StatusCode(500, new { message = "Error interno del servidor." });
            }

            //var result = await DeleteAsync(id, deleteType);

            //if (!result)
            //    return NotFound(new { message = "No se pudo eliminar el recurso." });

            //return Ok(new { message = $"Eliminación {deleteType} realizada correctamente." });
        }

        [HttpDelete("used/{playerId}/{cardId}")]
        public async Task<ActionResult<GameStartResultDto>> DeleteAll(int playerId,int cardId)
        {
            try
            {
                var result = await _service.DeleteUsed(playerId, cardId);

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
