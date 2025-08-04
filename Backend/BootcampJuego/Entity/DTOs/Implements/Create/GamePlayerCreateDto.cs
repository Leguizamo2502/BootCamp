using Entity.Domain.Models.Implements;
using Entity.DTOs.Base;

namespace Entity.DTOs.Implements.Create
{
    public class GamePlayerCreateDto : BaseDto
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int CurrentScore { get; set; }


    }
}
