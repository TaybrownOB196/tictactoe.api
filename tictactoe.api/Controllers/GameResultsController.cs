using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess.creators;
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
        public GameResultsController(
            IEntityProvider<GameResult> provider, 
            IEntityCreator<GameResult> creator)
        {
            _provider = provider;
            _creator = creator;
        }

        [HttpGet]
        public JsonResult Get(int playerId)
        {
            var results = _provider.Entities(playerId);
            return new JsonResult(results);
        }

        [HttpPost]
        public JsonResult Post([FromBody] GameResult gameResult)
        {
            _provider.Create(gameResult);
            return new JsonResult(responseBody);
        }
    }
}