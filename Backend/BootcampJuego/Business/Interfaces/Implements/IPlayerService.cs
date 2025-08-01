using Business.Interfaces.Repository;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Implements
{
    public interface IPlayerService : IBusinessGeneric<PlayerCreateDto, PlayerSelectDto>
    {
    }
}
