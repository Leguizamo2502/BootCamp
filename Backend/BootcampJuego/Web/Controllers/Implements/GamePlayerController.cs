using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class GamePlayerController : BaseController<GamePlayerCreateDto, GamePlayerSelectDto, IGamePLayerService>
    {
        public GamePlayerController(IGamePLayerService service, ILogger<GamePlayerController> logger) : base(service, logger)
        {
        }

        protected override async Task AddAsync(GamePlayerCreateDto dto)
        {
            await _service.CreateAsync(dto);
        }

        protected override async Task<bool> DeleteAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }

        protected override async Task<IEnumerable<GamePlayerSelectDto>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        protected override async Task<GamePlayerSelectDto?> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        protected override async Task<bool> UpdateAsync(int id, GamePlayerCreateDto dto)
        {
            return await _service.UpdateAsync(dto);
        }
    }
}
