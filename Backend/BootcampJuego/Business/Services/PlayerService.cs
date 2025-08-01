using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PlayerService : BusinesGeneric<PlayerCreateDto, PlayerSelectDto, Player>, IPlayerService
    {
        public PlayerService(IData<Player> data, IMapper mapper) : base(data, mapper)
        {
        }
    }
}
