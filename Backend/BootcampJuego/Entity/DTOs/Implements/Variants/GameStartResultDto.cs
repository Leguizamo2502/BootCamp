using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.Variants
{
    public class GameStartResultDto
    {
        public bool Success { get; set; }
        public int GameId { get; set; }
        public List<GamePlayerWithCardsDto> Players { get; set; } = new();
    }

}
