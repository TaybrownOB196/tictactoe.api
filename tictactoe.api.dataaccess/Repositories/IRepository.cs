using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace tictactoe.api.dataaccess.repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        T Add(T entity);
        void Remove(T entity);
        T Get(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}