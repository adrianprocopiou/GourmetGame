using System.Collections.Generic;

namespace GourmetGame.Application.Service.Interface
{
    public interface IAppService<TViewModel> where TViewModel : class
    {
        /// <summary>
        /// Add <paramref name="obj"/> in database
        /// </summary>
        /// <param name="obj"></param>
        void Add(TViewModel obj);
        /// <summary>
        /// Update <paramref name="obj"/> in database with Id property
        /// </summary>
        /// <param name="obj"></param>
        void Update(TViewModel obj);
        /// <summary>
        /// Check if an <paramref name="filter"/> expression is valid in database
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IEnumerable<TViewModel> GetAll();
    }
}