using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace tictactoe.api.dataaccess.repositories 
{
    public abstract class Repository<T> : IRepository<T> where T : class, IEntity
    {
        //Replace with an interface that wraps DbContext to make reusable outside of EF
        protected readonly DbContext _dbContext;
        protected virtual int _maxFindCount { get; set; }
        protected Repository(DbContext context)
        {
            _dbContext = context;
            _maxFindCount = 10;
        }

        public T Add(T entity)
        {
            var entityEntry = _dbContext.Set<T>().Add(entity);
            return entityEntry.Entity;
        }

        public T Get(int id)
        {
            var entity = _dbContext.Set<T>().Find(id);
            return entity;
        }

        public void Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            var entities = _dbContext.Set<T>().Where(predicate).Take(_maxFindCount).ToList();
            return entities;
        }
    }
}