﻿using System.Collections.Generic;
using AutoMapper;
using GourmetGame.Application.Service.Interface;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Service.Interfaces;

namespace GourmetGame.Application.Service
{
    public class AppService<TViewModel, TEntity, TService> : IAppService<TViewModel>
        where TViewModel : class
        where TEntity : Entity
        where TService : IService<TEntity>
    {
        protected readonly TService _service;

        public AppService(TService service)
        {
            _service = service;
        }

        public void Add(TViewModel obj)
        {
            var entity = Mapper.Map<TEntity>(obj);
            _service.Add(entity);
        }

        public void Update(TViewModel obj)
        {
            var entity = Mapper.Map<TEntity>(obj);
            _service.Update(entity);
        }

        public IEnumerable<TViewModel> GetAll()
        {
            var result = _service.GetAll();
            return result != null ? Mapper.Map<IEnumerable<TViewModel>>(result) : null;
        }
    }
}