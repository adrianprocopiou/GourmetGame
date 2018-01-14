using GourmetGame.Application.Service;
using GourmetGame.Application.Service.Interface;
using SimpleInjector;

namespace GourmetGame.Application.IoC
{
    public static class IoCManager
    {
        public static Container Container { get; private set; }
        public static void RegisterModules(Container container)
        {
            Container = container;
            container.Register<ICategoryAppService, CategoryAppService>();

            container.Register<IDishAppService, DishAppService>();
        }
    }
}