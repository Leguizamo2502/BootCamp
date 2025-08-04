using Entity.DTOs.Base;

namespace Entity.DTOs.Implements.Select
{
    public class GamePlayerSelectDto : BaseDto
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int CurrentScore { get; set; }

    }
}
