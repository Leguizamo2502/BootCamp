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
    public class RoomService : BusinesGeneric<RoomCreateDto, RoomSelectDto, Room>,IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IData<Room> data, IMapper mapper, IRoomRepository roomRepository) : base(data, mapper)
        {
            _roomRepository = roomRepository;
        }
    }
}
