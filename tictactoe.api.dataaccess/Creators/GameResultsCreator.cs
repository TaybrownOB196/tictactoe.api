using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.creators
{
    public class GameResultsCreator : IEntityCreator<GameResult>
    {
        private readonly TictactoeDbContext _db;
        public GameResultsCreator(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        } 

        public GameResult Create(GameResult entity)
        {
            var gameResult = _db.GameResults.Add(entity);
            _db.SaveChanges();
            return gameResult.Entity;
        }
    }
}