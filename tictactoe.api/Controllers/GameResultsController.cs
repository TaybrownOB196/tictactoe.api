using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameResultsController : ControllerBase
    {
        private readonly TictactoeDbContext _dbContext;
        public GameResultsController(TictactoeDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult Get(int playerId)
        {
            if (playerId <= 0) {
                return BadRequest("invalid player id");
            }
            using (var uow = new UnitOfWork(_dbContext)) 
            {
                var results = uow.GameResults.GetPlayerGameResults(playerId);

                return new JsonResult(results);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] GameResult gameResult)
        {
            using (var uow = new UnitOfWork(_dbContext)) 
            {
                var result = uow.GameResults.Add(gameResult);
                uow.Complete();

                return new JsonResult(result);
            }
        }
    }
}