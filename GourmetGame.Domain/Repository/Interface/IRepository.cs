using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Domain.Repository.Interface
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T obj);
        IEnumerable<T> GetAll();
        bool Any(Expression<Func<T, bool>> filter);
    }
}