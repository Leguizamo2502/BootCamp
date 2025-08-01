using Entity.Domain.Models.Implements;
using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.Create
{
    public class GamePlayerDto : BaseDto
    {
        public int PlayerId { get; set; }

        public int RoomId { get; set; }

        public bool Winner { get; set; }


    }
}
