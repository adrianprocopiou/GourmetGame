using GourmetGame.Data.Database;
using GourmetGame.Data.Database.Interface;
using GourmetGame.Data.Repository;
using GourmetGame.Domain.Repository.Interface;
using GourmetGame.Domain.Service;
using GourmetGame.Domain.Service.Interfaces;
using SimpleInjector;

namespace GourmetGame.IoC
{
    public static class IoCManager
    {
        public static Container RegisterModules()
        {
            var container = new Container();

            container.Register<IGourmetGameDb, GourmetGameDbList>(Lifestyle.Singleton);

            container.Register<ICategoryRepository, CategoryRepository>();
            container.Register<ICategoryService,CategoryService>();

            container.Register<IDishRepository, DishRepository>();
            container.Register<IDishService, DishService>();


            return container;
        }
    }
}