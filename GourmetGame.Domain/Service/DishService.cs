using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;

namespace GourmetGame.Domain.Service
{
    public class DishService : Service<Dish>
    {
        public DishService(IDishRepository dishRepository) : base(dishRepository)
        {
        }
    }
}