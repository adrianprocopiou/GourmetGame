using GourmetGame.Application.ViewModel;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Service.Interfaces;

namespace GourmetGame.Application.Service
{
    public class DishAppService : AppService<DishViewModel,Dish, IDishService>
    {
        public DishAppService(IDishService service) : base(service)
        {
        }
    }
}