using Entity.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domain.Models.Implements
{
    public class Player : BaseModel
    {
        public string Name { get; set; }
        public ICollection<GamePlayer> GamePlayers { get; set; }

    }
}
