using System.Collections.Generic;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;
using GourmetGame.Domain.Service.Interfaces;

namespace GourmetGame.Domain.Service
{
    public class Service<T> : IService<T> where T : Entity
    {
        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}