using Entity.Domain.Models.Implements;
using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.Create
{
    public class CardCreateDto : BaseDto
    {
        public string ImageUrl { get; set; }

        public int Health { get; set; }
        public int Speed { get; set; }
        public int Resistance { get; set; }
        public int Magic { get; set; }
        public int Force { get; set; }
        public int Defense { get; set; }
        public int? DeckId { get; set; }
    }
}
