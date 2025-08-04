using Entity.Domain.Models.Implements;
using Entity.DTOs.Base;

namespace Entity.DTOs.Implements.Create
{
    public class DeckCreateDto : BaseDto
    {
        public int GamePlayerId { get; set; }
        public int CardId { get; set; }

        public bool Used { get; set; }
    }
}
