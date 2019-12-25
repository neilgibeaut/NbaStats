using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NbaStats.Application.Games.Commands;
using NbaStats.Application.Games.Queries.Models;
using NbaStats.Domain.Games.State;

namespace NbaStats.Api.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GamesController : ApiController
    {
        private readonly ILogger<GamesController> _logger;
        private readonly IMediator _mediator;

        public GamesController(ILogger<GamesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        /// <summary>
        /// Creates a game in NbaStats database
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Id of created game</returns>
        [HttpPost]
        public async Task<ActionResult<long>> Create(GameCreateCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
