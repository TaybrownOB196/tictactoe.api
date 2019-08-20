using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess.creators;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IEntityCreator<Player> _creator;
        public PlayersController(IEntityCreator<Player> creator)
        {
            _creator = creator;
        }

        [HttpPost]
        public JsonResult Post([FromBody] Player player)
        {
            var responseBody = _creator.CreateEntity(player);
            return new JsonResult(responseBody);
        }
    }
}