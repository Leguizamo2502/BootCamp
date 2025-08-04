using Entity.Domain.Models.Implements;
using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.Select
{
    public class DeckSelectDto : BaseDto
    {
        public int GamePlayerId { get; set; }
        //public int CardId { get; set; }

        public string PlayerName { get; set; }
        public List<CardSelectDto> Cards { get; set; }

        public bool Used { get; set; }
    }
}
