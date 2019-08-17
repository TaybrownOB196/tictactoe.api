using Microsoft.EntityFrameworkCore;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess
{
    public class TictactoeDbContext : DbContext
    {
        public TictactoeDbContext(DbContextOptions<TictactoeDbContext> options)
            : base(options) { }

        public DbSet<GameResult> GameResults { get; set; }
        public DbSet<GameSession> GameSessions { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
