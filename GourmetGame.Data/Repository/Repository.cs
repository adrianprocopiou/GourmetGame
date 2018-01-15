using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GourmetGame.Data.Database.Interface;
using GourmetGame.Data.IoC;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;

namespace GourmetGame.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly IList<T> _dbSet;
        private readonly IGourmetGameDb db;

        public Repository()
        {
            db = IoCManager.Container.GetInstance<IGourmetGameDb>();
            _dbSet = db.Collection<T>();
        }

        public virtual void Add(T obj)
        {
            _dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            var objDb = _dbSet.FirstOrDefault(x => x.Id == obj.Id);
            if (objDb != null)
            {
                var indexOf = _dbSet.IndexOf(objDb);
                _dbSet[indexOf] = obj;
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            return _dbSet.AsQueryable().Any(filter);
        }

        public T FirsOrDefault(Expression<Func<T, bool>> filter)
        {
            return _dbSet.AsQueryable().FirstOrDefault(filter);
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> filter)
        {
            return _dbSet.AsQueryable().Where(filter);
        }
    }
}