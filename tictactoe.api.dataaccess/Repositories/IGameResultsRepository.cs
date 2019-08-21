using System.Collections.Generic;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.repositories
{
    public interface IGameResultsRepository : IRepository<GameResult>
    {
        IEnumerable<GameResult> GetPlayerGameResults(int playerId);
    }
}