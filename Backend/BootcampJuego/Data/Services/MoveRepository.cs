using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces.Implements;
using Data.Repository;
using Entity.Domain.Models.Implements;
using Entity.Infrastructure.Contexts;

namespace Data.Services
{
    public class MoveRepository : DataGeneric<Move>, IMoveRepository
    {
        public MoveRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
