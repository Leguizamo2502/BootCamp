using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class MoveController : BaseController<MoveCreateDto, MoveSelectDto, IMoveService>
    {
        public MoveController(IMoveService service, ILogger<MoveController> logger) : base(service, logger)
        {
        }

        protected override async Task AddAsync(MoveCreateDto dto)
        {
            await _service.CreateAsync(dto);
        }

        protected override async Task<bool> DeleteAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }

        protected override async Task<IEnumerable<MoveSelectDto>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        protected override async Task<MoveSelectDto?> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        protected override async Task<bool> UpdateAsync(int id, MoveCreateDto dto)
        {
            return await _service.UpdateAsync(dto);
        }
    }
}
