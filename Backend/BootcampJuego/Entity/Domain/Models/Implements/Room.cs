using Entity.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domain.Models.Implements
{
    public class Room : BaseModel
    {
        public DateTime Createat { get; set; } = DateTime.Now;
        public ICollection<GamePlayer> GamePlayers { get; set; }
    }
}
