using Entity.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domain.Models.Implements
{
    public class GamePlayer : BaseModel
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public bool Winner { get; set; }

        public ICollection<Deck> Decks { get; set; }
    }
}
