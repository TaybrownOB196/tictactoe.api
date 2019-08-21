using System.Collections.Generic;

namespace tictactoe.api.dataaccess.creators
{
    public interface IEntityCreator<T> where T : class, IEntity
    {
        T Create(T entity);
    }
}