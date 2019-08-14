using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tictactoe.api.Controllers
{
    using tictactoe.api.dataaccess.models;

    [Route("api/[controller]")]
    [ApiController]
    public class GameResultsController
    {
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