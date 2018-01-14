using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;

namespace GourmetGame.Domain.Service
{
    public class CategoryService : Service<Category>
    {
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }
    }
}