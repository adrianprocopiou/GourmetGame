using System;
using System.Collections.Generic;
using AutoMapper;
using GourmetGame.Application.Service.Interface;
using GourmetGame.Application.ViewModel;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Service.Interfaces;

namespace GourmetGame.Application.Service
{
    public class CategoryAppService : AppService<CategoryViewModel, Category, ICategoryService>, ICategoryAppService
    {
        public CategoryAppService(ICategoryService service) : base(service)
        {
        }

        public IEnumerable<CategoryViewModel> FindSubCategoriesById(Guid categoryId)
        {
            var result = _service.Where(x => x.CategoryId == categoryId);
            return result != null ? Mapper.Map<IEnumerable<CategoryViewModel>>(result) : null;
        }
    }
}