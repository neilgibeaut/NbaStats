using NbaStats.Domain.Teams.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaStats.Domain.Games.State
{
    public class Game
    {
        public long GameId { get; set; }

        public DateTime StartTime { get; set; }

        public long HomeTeamId { get; set; }

        public long AwayTeamId { get; set; }

        public int HomeTeamScore { get; set; }

        public int AwayTeamScore { get; set; }

        public Team HomeTeam { get; set; }
        
        public Team AwayTeam { get; set; }
    }
}
    