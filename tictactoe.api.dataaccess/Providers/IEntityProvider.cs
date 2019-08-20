using System;
using System.Collections.Generic;

namespace tictactoe.api.dataaccess.providers
{
    public interface IEntityProvider<T> where T : class, IEntity
    {
        IEnumerable<T> Entities();
        IEnumerable<T> Entities(int id);
    }
}