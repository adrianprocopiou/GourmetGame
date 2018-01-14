using System.Collections.Generic;
using GourmetGame.Data.Database.Interface;
using GourmetGame.Data.IoC;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;

namespace GourmetGame.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly ICollection<T> _dbSet;
        private readonly IGourmetGameDb db;

        public Repository()
        {
            db = IoCManager.Container.GetInstance<IGourmetGameDb>();
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