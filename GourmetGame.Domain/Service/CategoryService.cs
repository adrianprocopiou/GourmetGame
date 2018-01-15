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

        public override void Add(Category obj)
        {
            if (!string.IsNullOrWhiteSpace(obj.Name)
                && !string.IsNullOrWhiteSpace(obj?.Dish?.Name)
                && !Any(x => x.Name == obj.Name))
                base.Add(obj);
        }
    }
}