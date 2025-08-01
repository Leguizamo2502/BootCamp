using Entity.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domain.Models.Implements
{
    public class Card : BaseModel
    {
        public string ImageUrl { get; set; }

        public int Salud { get; set; }
        public int Velocidad { get; set; }
        public int Resistencia { get; set; }
        public int Magia { get; set; }
        public int Fuerza { get; set; }
        public int Defensa { get; set; }
        public int? DeckId { get; set; }
        public Deck? Deck { get; set; }
    }
}
