using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTOs.Base;

namespace Entity.DTOs.Implements.Create
{
    public class RoundCreateDto : BaseDto
    {
        public int NumberRound { get; set; }
        public string SelectedAttribute { get; set; }
        public int GameId { get; set; }
    }
}
