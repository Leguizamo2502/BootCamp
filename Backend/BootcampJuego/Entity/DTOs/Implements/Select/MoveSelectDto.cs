using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTOs.Base;

namespace Entity.DTOs.Implements.Select
{
    public class MoveSelectDto : BaseDto
    {
        public int UsedValue { get; set; }
        public bool Winner { get; set; }
        public int RoundId { get; set; }
        public int CardId { get; set; }
        public int GamePlayerId { get; set; }
    }
}
