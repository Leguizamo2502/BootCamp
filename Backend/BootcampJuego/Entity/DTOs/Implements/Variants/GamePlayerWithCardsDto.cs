using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTOs.Implements.Select;

namespace Entity.DTOs.Implements.Variants
{
    public class GamePlayerWithCardsDto
    {
        public int GamePlayerId { get; set; }
        public string PlayerName { get; set; } = string.Empty;
        public List<CardSelectDto> Cards { get; set; } = new();
    }

}
