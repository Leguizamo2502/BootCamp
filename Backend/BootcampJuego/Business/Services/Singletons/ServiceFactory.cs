using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces.Implements;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Services.Singletons
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPlayerRepository GetPlayerRepository()
            => _serviceProvider.GetRequiredService<IPlayerRepository>();

        public ICardRepository GetCardRepository()
            => _serviceProvider.GetRequiredService<ICardRepository>();
    }
}
