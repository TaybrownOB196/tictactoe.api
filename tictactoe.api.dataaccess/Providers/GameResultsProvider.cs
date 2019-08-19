using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.providers
{
    public class GameResultsProvider : IEntityProvider<GameResult>
    {
        private readonly TictactoeDbContext _db;
        public GameResultsProvider(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        } 

        public GameResult AddEntity(GameResult entity)
        {
            var gameResult = _db.GameResults.Add(entity);
            _db.SaveChanges();
            return gameResult.Entity;
        }

        public IEnumerable<GameResult> Entities()
        {
            return _db.GameResults.Take(10);
        }
    }
}