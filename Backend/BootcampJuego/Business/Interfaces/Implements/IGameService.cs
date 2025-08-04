using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces.Repository;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Entity.DTOs.Implements.Variants;

namespace Business.Interfaces.Implements
{
    public interface IGameService : IBusinessGeneric<GameCreateDto,GameSelectDto>
    {
        Task<GameStartResultDto> StartGameAsync(int gameId);
    }
}
