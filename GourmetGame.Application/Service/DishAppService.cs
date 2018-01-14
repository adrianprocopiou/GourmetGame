using GourmetGame.Application.Service.Interface;
using GourmetGame.Application.ViewModel;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Service.Interfaces;

namespace GourmetGame.Application.Service
{
    public class DishAppService : AppService<DishViewModel,Dish, IDishService>, IDishAppService
    {
        public DishAppService(IDishService service) : base(service)
        {
        }
    }
}