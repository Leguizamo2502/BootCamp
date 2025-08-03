using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.Implements;
using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using MapsterMapper;

namespace Business.Services
{
    public class GamePlayerService : BusinesGeneric<GamePlayerCreateDto, GamePlayerSelectDto, GamePlayer>,IGamePLayerService
    {
        private readonly IGamePlayerRepository _gamePlayerRepository;
        public GamePlayerService(IData<GamePlayer> data, IMapper mapper, IGamePlayerRepository gamePlayerRepository) : base(data, mapper)
        {
            _gamePlayerRepository = gamePlayerRepository;
        }
    }
}
