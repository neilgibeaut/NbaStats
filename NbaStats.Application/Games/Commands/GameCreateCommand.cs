using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaStats.Application.Games.Commands
{
    public class GameCreateCommand : IRequest<long>
    {
        public string HomeTeamName { get; set; }

        public string AwayTeamName { get; set; }

        public DateTime StartTime { get; set; }

        public int HomeTeamScore { get; set; }

        public int AwayTeamScore { get; set; }
    }
}
