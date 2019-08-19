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
        public JsonResult Post([FromBody] Player player)
        {
            var responseBody = _provider.AddEntity(player);
            return new JsonResult(responseBody);
        }
    }
}