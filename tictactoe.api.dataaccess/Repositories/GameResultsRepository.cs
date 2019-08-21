using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.repositories
{
    public class GameResultsRepository : Repository<GameResult>, IGameResultsRepository
    {
        public GameResultsRepository(TictactoeDbContext context)
            : base(context) { }

        public TictactoeDbContext DbContext { get { return _dbContext as TictactoeDbContext; } }

        public IEnumerable<GameResult> GetPlayerGameResults(int playerId)
        {
            var results = DbContext.GameResults.Where(gameResult => gameResult.playerOneId == playerId).ToList();
            return results;
        }
    }
}