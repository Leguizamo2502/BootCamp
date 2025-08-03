using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class RoomController : BaseController<RoomCreateDto, RoomSelectDto, IRoomService>
    {
        public RoomController(IRoomService service, ILogger<RoomController> logger) : base(service, logger)
        {
        }

        protected override async Task AddAsync(RoomCreateDto dto)
        {
            await _service.CreateAsync(dto);
        }

        protected override async Task<bool> DeleteAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }

        protected override async Task<IEnumerable<RoomSelectDto>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        protected override async Task<RoomSelectDto?> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        protected override async Task<bool> UpdateAsync(int id, RoomCreateDto dto)
        {
            return await _service.UpdateAsync(dto);
        }
    }
}
