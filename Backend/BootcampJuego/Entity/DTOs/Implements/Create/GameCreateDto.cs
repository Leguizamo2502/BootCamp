using Entity.DTOs.Base;

namespace Entity.DTOs.Implements.Create
{
    public class GameCreateDto : BaseDto
    {
        public DateTime Createat { get; set; } = DateTime.Now;
    }
}
