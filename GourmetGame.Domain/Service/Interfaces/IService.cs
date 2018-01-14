using System.Collections.Generic;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Domain.Service.Interfaces
{
    public interface IService<T> where T : Entity
    {
        void Add(T obj);
        IEnumerable<T> GetAll();
    }
}