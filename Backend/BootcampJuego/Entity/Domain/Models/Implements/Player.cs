using Entity.Domain.Models.Base;

namespace Entity.Domain.Models.Implements
{
    public class Player : BaseModel
    {
        public string Name { get; set; }
        public bool Active { get; set; } = true;
        public ICollection<GamePlayer> GamePlayers { get; set; }

    }
}
