using Entity.DTOs.Base;

namespace Entity.DTOs.Implements.Create
{
    public class RoomCreateDto : BaseDto
    {
        public DateTime Createat { get; set; } = DateTime.Now;
    }
}
