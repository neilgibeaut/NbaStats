using MediatR;
using NbaStats.Data;
using NbaStats.Domain.Games.State;
using System;
using System.Collections.Generic;
using System.Linq;
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
                HomeTeam = _context.Teams.Single(x => x.Name == request.HomeTeamName),
                AwayTeam = _context.Teams.Single(x => x.Name == request.AwayTeamName),
                HomeTeamScore = request.HomeTeamScore,
                AwayTeamScore = request.AwayTeamScore
            };

            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();

            return game.GameId;
        }
    }
}
