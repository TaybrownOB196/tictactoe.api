using Microsoft.EntityFrameworkCore;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess
{
    public class DbEntities : DbContext
    {
        public DbEntities(DbContextOptions<DbEntities> options)
            : base(options) { }

        public DbSet<GameResult> GameResults { get; set; }
        public DbSet<GameSession> GameSessions { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
