using SimpleInjector;

namespace GourmetGame.IoC
{
    public static class IoCManager
    {
        private static Container container;

        public static Container GetContainer()
        {
            if (container != null) return container;

            container = new Container();

            Data.IoC.IoCManager.RegisterModules(container);
            Application.IoC.IoCManager.RegisterModules(container);

            return container;
        }
    }
}