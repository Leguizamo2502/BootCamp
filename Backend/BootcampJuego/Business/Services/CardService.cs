using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces.Implements;
using Business.Interfaces.Repository;
using Business.Repository;
using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using MapsterMapper;

namespace Business.Services
{
    public class CardService : BusinesGeneric<CardCreateDto, CardSelectDto, Card>, ICardService
    {
        public CardService(IData<Card> data, IMapper mapper) : base(data, mapper)
        {
        }
    }
}
