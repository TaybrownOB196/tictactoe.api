using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.creators
{
    public class GameSessionsCreator : IEntityCreator<GameSession>
    {
        private readonly TictactoeDbContext _db;
        public GameSessionsCreator(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        } 

        public GameSession Create(GameSession entity)
        {
            var gameSession = _db.GameSessions.Add(entity);
            _db.SaveChanges();
            return gameSession.Entity;
        }
    }
}