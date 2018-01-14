using System.Collections.Generic;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Domain.Repository.Interface
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T obj);
        IEnumerable<T> GetAll();
    }
}