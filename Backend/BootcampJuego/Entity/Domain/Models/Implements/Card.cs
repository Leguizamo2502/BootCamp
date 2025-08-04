using Entity.Domain.Models.Base;

namespace Entity.Domain.Models.Implements
{
    public class Card : BaseModel
    {
        public string ImageUrl { get; set; }

        public int Health { get; set; }
        public int Speed { get; set; }
        public int Resistance { get; set; }
        public int Magic { get; set; }
        public int Force { get; set; }
        public int Defense { get; set; }
        public ICollection<Deck> Decks { get; set; }
        public ICollection<Move> Moves { get; set; }
    }
}
