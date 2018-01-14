using System.Collections.Generic;
using GourmetGame.Data.Database;
using GourmetGame.Data.Database.Interface;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;
using Microsoft.Practices.ServiceLocation;

namespace GourmetGame.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {

        private readonly ICollection<T> _dbSet;
        private readonly IGourmetGameDb db;
        public Repository()
        {
            db = IoC.IoCManager.Container.GetInstance<IGourmetGameDb>();
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