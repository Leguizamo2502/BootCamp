using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces.Repository;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;

namespace Business.Interfaces.Implements
{
    public interface IGamePLayerService : IBusinessGeneric<GamePlayerCreateDto,GamePlayerSelectDto>
    {
    }
}
