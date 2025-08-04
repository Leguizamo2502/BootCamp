using Entity.Domain.Models.Base;

namespace Entity.Domain.Models.Implements
{
    public class GamePlayer : BaseModel
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int CurrentScore { get; set; }

        public ICollection<Deck> Decks { get; set; }
        public ICollection<Move> Moves { get; set; }


    }
}
