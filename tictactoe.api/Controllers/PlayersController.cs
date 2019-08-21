using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly TictactoeDbContext _dbContext;
        public PlayersController(TictactoeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public JsonResult Post([FromBody] Player player)
        {
            using (var uow = new UnitOfWork(_dbContext)) 
            {
                var result = uow.Players.Add(player);
                uow.Complete();

                return new JsonResult(result);
            }
        }
    }
}