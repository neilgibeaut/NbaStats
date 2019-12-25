using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Heroic.AutoMapper;
using NbaStats.Domain.Games.State;

namespace NbaStats.Application.Games.Queries.Models
{
    public class GameDetail : IMapFrom<Game>, IHaveCustomMappings
    {
        public long GameId { get; set; }

        public string HomeTeamName { get; set; }

        public string AwayTeamName { get; set; }

        public int HomeTeamScore { get; set; }

        public int AwayTeamScore { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Game, GameDetail>()
                .ForMember(d => d.HomeTeamName, opt => opt.MapFrom(s => s.HomeTeam.Name))
                .ForMember(d => d.AwayTeamName, opt => opt.MapFrom(s => s.AwayTeam.Name));
        }
    }
}
