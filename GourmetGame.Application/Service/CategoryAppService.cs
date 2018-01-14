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
    }
}