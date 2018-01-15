using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Domain.Service.Interfaces
{
    public interface IService<T> where T : Entity
    {
        void Add(T obj);
        void Update(T obj);
        IEnumerable<T> GetAll();
        bool Any(Expression<Func<T, bool>> filter);
        T FirsOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> Where(Expression<Func<T, bool>> filter);
    }
}