using System;
using tictactoe.api.dataaccess.repositories;

namespace tictactoe.api.dataaccess
{
    public interface IUnitOfWork : IDisposable
    {
        IGameResultsRepository GameResults { get; }
        IPlayersRepository Players { get; }
        int Complete();
    }
}