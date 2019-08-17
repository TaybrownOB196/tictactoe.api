using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameResultsController : ControllerBase
    {
        private readonly DbEntities _entities;
        public GameResultsController(DbEntities entities)
        {
            _entities = entities;
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