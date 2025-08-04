using Entity.Domain.Models.Implements;
using Entity.DTOs.Implements.Select;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public static class MapsterConfig
    {
        public static TypeAdapterConfig Register()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<Deck, DeckSelectDto>().Map(des => des.PlayerName, src => src.GamePlayer.Player.Name);
            

            return config;
        }
    }
}
