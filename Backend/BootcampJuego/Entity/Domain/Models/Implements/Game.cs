using Entity.Domain.Models.Base;

namespace Entity.Domain.Models.Implements
{
    public class Game : BaseModel
    {
        public DateTime CreateAt { get; set; } = DateTime.Now;
        //public string Status { get; set; }
        public ICollection<Round> Rounds { get; set; }
        public ICollection<GamePlayer> GamePlayers { get; set; }

    }
}
