using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces.Implements;

namespace Business.Services.Singletons
{
    public interface IServiceFactory
    {
        IPlayerRepository GetPlayerRepository();
        ICardRepository GetCardRepository();
    }
}
