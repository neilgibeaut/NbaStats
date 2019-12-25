using MediatR;
using NbaStats.Data;
using NbaStats.Domain.Games.State;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NbaStats.Application.Games.Commands
{
    public class GameCreateCommandHandler : IRequestHandler<GameCreateCommand, long>
    {
        private readonly NbaStatsDbContext _context;

        public GameCreateCommandHandler(NbaStatsDbContext context)
        {
            _context = context;
        }
        public async Task<long> Handle(GameCreateCommand request, CancellationToken cancellationToken)
        {
            // TODO: Use AutoMapper for this type of thing. 
            // Maybe can use detail models as commands for creation
            var game = new Game()
            {
                StartTime = request.StartTime,
                HomeTeamName = request.HomeTeamName,
                AwayTeamName = request.AwayTeamName,
                HomeTeamScore = request.HomeTeamScore,
                AwayTeamScore = request.AwayTeamScore
            };

            await _context.Games.AddAsync(game);
            return game.GameId;
        }
    }
}
