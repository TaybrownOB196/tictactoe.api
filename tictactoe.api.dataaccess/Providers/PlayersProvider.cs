using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;
using tictactoe.api.dataaccess.providers;

namespace tictactoe.api.dataaccess 
{
    public class PlayersProvider : IEntityProvider<Player>
    {
        private readonly TictactoeDbContext _db;
        public PlayersProvider(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        } 

        public void AddEntity(Player entity)
        {
            _db.Players.Add(entity);
            _db.SaveChanges();
        }

        public IEnumerable<Player> Entities()
        {
            return _db.Players.Take(10);
        }
    }
}