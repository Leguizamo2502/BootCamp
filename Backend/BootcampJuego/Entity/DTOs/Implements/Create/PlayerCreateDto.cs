using Entity.DTOs.Base;

namespace Entity.DTOs.Implements.Create
{
    public class PlayerCreateDto : BaseDto
    {
        public string Name { get; set; }
        //public bool Active { get; set; } = true;
    }
}
