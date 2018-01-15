using System;
using System.Collections.Generic;
using GourmetGame.Application.ViewModel;

namespace GourmetGame.Application.Service.Interface
{
    public interface ICategoryAppService : IAppService<CategoryViewModel>
    {
        /// <summary>
        /// Find all subcategories in database with <paramref name="categoryId"/> specified
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        IEnumerable<CategoryViewModel> FindSubCategoriesById(Guid categoryId);
    }
}