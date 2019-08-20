using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;
using System;

namespace tictactoe.api.dataaccess.providers
{
    public class PlayersProvider : IEntityProvider<Player>
    {
        private readonly TictactoeDbContext _db;
        public PlayersProvider(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        }
        
        public IEnumerable<Player> Entities()
        {
            return _db.Players.Take(10);
        }
    }
}