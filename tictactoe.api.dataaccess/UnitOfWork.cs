using tictactoe.api.dataaccess.repositories;

namespace tictactoe.api.dataaccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TictactoeDbContext _dbContext;
        public UnitOfWork(TictactoeDbContext dbContext)
        {
            _dbContext = dbContext;
            GameResults = new GameResultsRepository(_dbContext);
            Players = new PlayersRepository(_dbContext);
        }

        public IGameResultsRepository GameResults { get; }
        public IPlayersRepository Players { get; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}