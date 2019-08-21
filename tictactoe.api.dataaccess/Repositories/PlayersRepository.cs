using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.repositories
{
    public class PlayersRepository : Repository<Player>, IPlayersRepository
    {
        public PlayersRepository(TictactoeDbContext context)
            : base(context) { }

        public TictactoeDbContext DbContext { get { return _dbContext as TictactoeDbContext; } }
    }
}