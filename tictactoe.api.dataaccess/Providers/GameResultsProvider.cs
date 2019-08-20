using System.Linq;
using System.Collections.Generic;
using tictactoe.api.dataaccess.models;
using System;

namespace tictactoe.api.dataaccess.providers
{
    public class GameResultsProvider : IEntityProvider<GameResult>
    {
        private readonly TictactoeDbContext _db;
        public GameResultsProvider(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        }

        public IEnumerable<GameResult> Entities()
        {
            return _db.GameResults.Take(10);
        }

        public IEnumerable<GameResult> Entities(int id)
        {
            return _db.GameResults
                .Where(gr => gr.id == id)
                .Take(10);
        }
    }
}