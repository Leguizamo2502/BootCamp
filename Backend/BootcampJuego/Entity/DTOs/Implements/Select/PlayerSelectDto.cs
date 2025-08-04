using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.Select
{
    public class PlayerSelectDto : BaseDto
    {
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
