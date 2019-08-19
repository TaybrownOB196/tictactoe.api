using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.providers
{
    public class PlayersProvider : IEntityProvider<Player>
    {
        private readonly TictactoeDbContext _db;
        public PlayersProvider(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        } 

        public Player AddEntity(Player entity)
        {
            var player = _db.Players.Add(entity);
            _db.SaveChanges();
            return player.Entity;
        }

        public IEnumerable<Player> Entities()
        {
            return _db.Players.Take(10);
        }
    }
}