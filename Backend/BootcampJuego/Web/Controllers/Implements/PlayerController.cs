using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
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
    }
}
