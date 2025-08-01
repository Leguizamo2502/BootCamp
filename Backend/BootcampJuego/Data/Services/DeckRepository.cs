using Data.Interfaces.Implements;
using Data.Repository;
using Entity.Domain.Models.Implements;
using Entity.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class DeckRepository : DataGeneric<Deck>, IDeckRepository
    {
        public DeckRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
