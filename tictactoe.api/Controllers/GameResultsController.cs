using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess.models;
using tictactoe.api.dataaccess.creators;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameResultsController : ControllerBase
    {
        private readonly IEntityCreator<GameResult> _provider;
        public GameResultsController(IEntityCreator<GameResult> provider)
        {
            _provider = provider;
        }

        [HttpPost]
        public ActionResult Post([FromBody] GameResult gameResult)
        {
            _provider.Create(gameResult);
            return new OkResult();
        }
    }
}