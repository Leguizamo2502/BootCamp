using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class RoundController : BaseController<RoundCreateDto, RoundSelectDto, IRoundService>
    {
        public RoundController(IRoundService service, ILogger<RoundController> logger) : base(service, logger)
        {
        }

        protected override async Task AddAsync(RoundCreateDto dto)
        {
            await _service.CreateAsync(dto);
        }

        protected override async Task<bool> DeleteAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }

        protected override async Task<IEnumerable<RoundSelectDto>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        protected override async Task<RoundSelectDto?> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        protected override async Task<bool> UpdateAsync(int id, RoundCreateDto dto)
        {
            return await _service.UpdateAsync(dto);
        }
    }
}
