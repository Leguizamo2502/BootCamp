using Business.Interfaces.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Web.Controllers.Base;

namespace Web.Controllers.Implements
{
    public class PlayerController : BaseController<PlayerCreateDto,PlayerSelectDto,IPlayerService>
    {
    }
}
