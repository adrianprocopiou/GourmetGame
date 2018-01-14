using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;
using GourmetGame.Domain.Service.Interfaces;

namespace GourmetGame.Domain.Service
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }
    }
}