using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;

namespace Data.Interfaces.Implements
{
    public interface IMoveRepository : IData<Move>
    {
    }
}
