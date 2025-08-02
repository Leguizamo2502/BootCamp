using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class CardController : BaseController<CardCreateDto, CardSelectDto, ICardService>
    {
        public CardController(ICardService service, ILogger<CardController> logger) : base(service, logger)
        {
        }

        protected override async Task AddAsync(CardCreateDto dto)
        {
            await _service.CreateAsync(dto);
        }

        protected override async Task<bool> DeleteAsync(int id)
        {
            return await _service.DeleteAsync(id);
        }

        protected override async Task<IEnumerable<CardSelectDto>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        protected override async Task<CardSelectDto?> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        protected override async Task<bool> UpdateAsync(int id, CardCreateDto dto)
        {
            return await _service.UpdateAsync(dto);
        }
    }
}
