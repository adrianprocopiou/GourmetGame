using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;
using GourmetGame.Domain.Service.Interfaces;

namespace GourmetGame.Domain.Service
{
    public class DishService : Service<Dish>, IDishService
    {
        public DishService(IDishRepository dishRepository) : base(dishRepository)
        {
        }
    }
}