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
            if (!Any(x => x.Name == obj.Name))
                base.Add(obj);
        }
    }
}