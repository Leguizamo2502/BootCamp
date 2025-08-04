using Entity.Domain.Models.Base;

namespace Entity.Domain.Models.Implements
{
    public class Deck : BaseModel
    {
        public int GamePlayerId { get; set; }
        public GamePlayer GamePlayer { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public bool Used { get; set; }



    }
}
