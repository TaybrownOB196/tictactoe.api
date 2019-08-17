using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess.models;
using tictactoe.api.dataaccess.providers;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameResultsController : ControllerBase
    {
        private readonly IEntityProvider<GameResult> _provider;
        public GameResultsController(IEntityProvider<GameResult> provider)
        {
            _provider = provider;
        }

        [HttpGet]
        public JsonResult Get(string playerName)
        {
            var results = new List<GameResult> { GameResult.getDummy() };
            return new JsonResult(results);
        }

        [HttpPost]
        public ActionResult Post([FromBody] GameResult gameResult)
        {
            return new OkResult();
        }
    }
}