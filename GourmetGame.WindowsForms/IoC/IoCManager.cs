using GourmetGame.WindowsForms.Service;
using GourmetGame.WindowsForms.Service.Interface;
using SimpleInjector;

namespace GourmetGame.WindowsForms.IoC
{
    public static class IoCManager
    {
        public static void RegisterModules(Container container)
        {
            container.Register<MainForm>();
            container.Register<IMainFormService,MainFormService>();
            container.Register<IUserDisplayMessageService, UserDisplayMessageService>();
        }
    }
}