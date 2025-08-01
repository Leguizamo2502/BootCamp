using Entity.Domain.Models.Implements;
using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.Create
{
    public class DeckCreateDto : BaseDto
    {
        public int GamePlayerId { get; set; }


        public bool Active { get; set; } = true;
    }
}
