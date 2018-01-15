using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Domain.Service.Interfaces
{
    public interface IService<T> where T : Entity
    {
        /// <summary>
        /// Add <paramref name="obj"/> in database
        /// </summary>
        /// <param name="obj"></param>
        void Add(T obj);
        /// <summary>
        /// Update <paramref name="obj"/> in database with Id property
        /// </summary>
        /// <param name="obj"></param>
        void Update(T obj);
        /// <summary>
        /// Get all objects in database
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Check if an <paramref name="filter"/> expression is valid in database
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        bool Any(Expression<Func<T, bool>> filter);
        /// <summary>
        /// Retrieve the first object in database corresponding with <paramref name="filter"/>
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        T FirsOrDefault(Expression<Func<T, bool>> filter);
        /// <summary>
        /// Retrive an collection object in database corresponding with <paramref name="filter"/>
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IEnumerable<T> Where(Expression<Func<T, bool>> filter);
    }
}