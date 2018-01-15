using GourmetGame.Data.Database;
using GourmetGame.Data.Database.Interface;
using GourmetGame.Data.Repository;
using GourmetGame.Domain.Repository.Interface;
using GourmetGame.Domain.Service;
using GourmetGame.Domain.Service.Interfaces;
using SimpleInjector;

namespace GourmetGame.Data.IoC
{
    public static class IoCManager
    {
        public static Container Container { get; private set; }

        public static void RegisterModules(Container container)
        {
            Container = container;
            container.Register<IGourmetGameDb, GourmetGameDbList>(Lifestyle.Singleton);

            container.Register<ICategoryService, CategoryService>();
            container.Register<ICategoryRepository, CategoryRepository>();
        }
    }
}