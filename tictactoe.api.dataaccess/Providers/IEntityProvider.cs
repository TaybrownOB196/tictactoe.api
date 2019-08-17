using System.Collections.Generic;

namespace tictactoe.api.dataaccess.providers
{
    public interface IEntityProvider<T> where T : class, IEntity
    {
        IEnumerable<T> Entities();
        void AddEntity(T entity);
    }
}