using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess.models;
using tictactoe.api.dataaccess.providers;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IEntityProvider<Player> _provider;
        public PlayersController(IEntityProvider<Player> provider)
        {
            _provider = provider;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Player Player)
        {
            _provider.AddEntity(Player);
            return new OkResult();
        }
    }
}