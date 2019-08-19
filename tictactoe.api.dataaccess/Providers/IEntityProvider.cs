using System.Collections.Generic;

namespace tictactoe.api.dataaccess.providers
{
    public interface IEntityProvider<T> where T : class, IEntity
    {
        IEnumerable<T> Entities();
        T AddEntity(T entity);
    }
}