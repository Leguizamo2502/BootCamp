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
            config.NewConfig<Card, CardSelectDto>();

            config.NewConfig<List<Deck>, DeckSelectDto>()
                 .Map(dest => dest.GamePlayerId, src => src.First().GamePlayerId)
                 .Map(dest => dest.PlayerName, src => src.First().GamePlayer.Player.Name)
                 .Map(dest => dest.Used, src => src.First().Used)
                 //.Map(dest => dest.CardId, src => src.First().CardId)
                 .Map(dest => dest.Cards, src => src.Select(d => d.Card));

            return config;
        }
    }
}
