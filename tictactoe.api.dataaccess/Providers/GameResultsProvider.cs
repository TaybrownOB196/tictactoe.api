using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;
using tictactoe.api.dataaccess.providers;

namespace tictactoe.api.dataaccess 
{
    public class GameResultsProvider : IEntityProvider<GameResult>
    {
        private readonly TictactoeDbContext _db;
        public GameResultsProvider(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        } 

        public void AddEntity(GameResult entity)
        {
            _db.GameResults.Add(entity);
            _db.SaveChanges();
        }

        public IEnumerable<GameResult> Entities()
        {
            return _db.GameResults.Take(10);
        }
    }
}