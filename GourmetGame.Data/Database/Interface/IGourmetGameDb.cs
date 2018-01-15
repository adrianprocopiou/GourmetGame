using System.Collections.Generic;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Data.Database.Interface
{
    public interface IGourmetGameDb
    {
        /// <summary>
        /// The dbSet of Category Entity
        /// </summary>
        IList<Category> Category { get; set; }
        /// <summary>
        /// Get an dbSet based in type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IList<T> Collection<T>() where T : Entity;
    }
}