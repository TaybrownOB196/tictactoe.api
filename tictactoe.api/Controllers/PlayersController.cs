using Microsoft.AspNetCore.Mvc;
using tictactoe.api.dataaccess.models;
using tictactoe.api.dataaccess.creators;

namespace tictactoe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IEntityCreator<Player> _provider;
        public PlayersController(IEntityCreator<Player> provider)
        {
            _provider = provider;
        }

        [HttpPost]
        public JsonResult Post([FromBody] Player player)
        {
            var responseBody = _provider.Create(player);
            return new JsonResult(responseBody);
        }
    }
}