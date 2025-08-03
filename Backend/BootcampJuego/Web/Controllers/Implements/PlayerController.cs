using System.ComponentModel.DataAnnotations;
using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class PlayerController : BaseController<PlayerCreateDto, PlayerSelectDto, IPlayerService>
    {
        public PlayerController(IPlayerService service, ILogger<PlayerController> logger) : base(service, logger)
        {
        }

        protected override async Task AddAsync(PlayerCreateDto dto)
        {
            await _service.CreateAsync(dto);
        }

        protected override async Task<bool> DeleteAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }


        protected override async Task<IEnumerable<PlayerSelectDto>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        protected override async Task<PlayerSelectDto?> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        protected override async Task<bool> UpdateAsync(int id, PlayerCreateDto dto)
        {
            return await _service.UpdateAsync(dto);
        }

        [HttpGet("Delete")]
        //[ProducesResponseType(typeof(IEnumerable<TDto>), 200)]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public virtual async Task<IActionResult> GetDeletes()
        {
            try
            {
                var result = await _service.GetAllDeletes();
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
        [HttpPatch("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DeleteLogic(int id)
        {
            try
            {
                var result = await _service.DeleteLogic(id);

                if (result<0)
                    return NotFound(new { message = "No se pudo eliminar el recurso." });

                return Ok(new { message = $"Eliminación realizada correctamente." });
            }
            catch (ValidationException ex)
            {
                _logger.LogWarning(ex, "Validación fallida al eliminar recurso con id: {ResourceId}", id);
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado al eliminar recurso con id: {ResourceId}", id);
                return StatusCode(500, new { message = "Error interno del servidor." });
            }
        }

        [HttpPatch("restore/{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RestoreLogical(int id)
        {
            try
            {
                var result = await _service.RestoreLogic(id);
                if (result<0)
                    return NoContent();

                return NotFound(new { message = $"Rol con id {id} no encontrado o no está marcado como eliminado." });
            }
            catch (ValidationException ex)
            {
                _logger.LogWarning(ex, "Validación fallida al restaurar lógicamente Rol con id: {RolId}", id);
                return BadRequest(new { message = ex.Message });
            }

        }

    }
}
