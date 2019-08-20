using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess.creators;
using tictactoe.api.dataaccess.models;
using tictactoe.api.dataaccess.providers;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameResultsController : ControllerBase
    {
        private readonly IEntityProvider<GameResult> _provider;
        private readonly IEntityCreator<GameResult> _creator;
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
            var responseBody = _creator.CreateEntity(gameResult);
            return new JsonResult(responseBody);
        }
    }
}