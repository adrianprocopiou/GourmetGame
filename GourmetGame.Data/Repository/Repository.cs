using System.Collections.Generic;
using GourmetGame.Data.Database.Interface;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;
using Microsoft.Practices.ServiceLocation;

namespace GourmetGame.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {

        private readonly ICollection<T> _dbSet;

        public Repository()
        {
            var db = ServiceLocator.Current.GetInstance<IDatabaseManager>().GetInstance();
            _dbSet = db.Collection<T>();
        }

        public void Add(T obj)
        {
            _dbSet.Add(obj);
            
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }
    }
}