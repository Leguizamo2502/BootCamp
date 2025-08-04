using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Domain.Models.Base;

namespace Entity.Domain.Models.Implements
{
    public class Round :BaseModel
    {
        public int NumberRound { get; set; }
        public string SelectedAttribute { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public ICollection<Move> Moves { get; set; }
    }
}
