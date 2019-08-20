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

        public GameResult CreateEntity(GameResult entity)
        {
            var GameResult = _db.GameResults.Add(entity);
            _db.SaveChanges();
            return GameResult.Entity;
        }
    }
}