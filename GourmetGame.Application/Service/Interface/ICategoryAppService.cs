using System;
using System.Collections.Generic;
using GourmetGame.Application.ViewModel;

namespace GourmetGame.Application.Service.Interface
{
    public interface ICategoryAppService : IAppService<CategoryViewModel>
    {
        IEnumerable<CategoryViewModel> FindSubCategoriesById(Guid categoryId);
    }
}