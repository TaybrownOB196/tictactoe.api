using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.providers
{
    public class GameSessionsProvider : IEntityProvider<GameSession>
    {
        private readonly TictactoeDbContext _db;
        public GameSessionsProvider(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        } 

        public GameSession AddEntity(GameSession entity)
        {
            var gameSession = _db.GameSessions.Add(entity);
            _db.SaveChanges();
            return gameSession.Entity;
        }

        public IEnumerable<GameSession> Entities()
        {
            return _db.GameSessions.Take(10);
        }
    }
}