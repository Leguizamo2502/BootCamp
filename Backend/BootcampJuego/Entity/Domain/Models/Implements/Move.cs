using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Domain.Models.Base;

namespace Entity.Domain.Models.Implements
{
    public class Move :BaseModel
    {
        public int UsedValue { get; set; }
        public bool Winner { get; set; }
        public int RoundId { get; set; }
        public Round Round { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int GamePlayerId { get; set; }
        public GamePlayer GamePlayer { get; set; }
    }
}
