using System;
using GourmetGame.IoC;
using SimpleInjector;

namespace GourmetGame.WindowsForms
{
    static class Program
    {

        // Container for IoC and DI
        private static Container _container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _container = IoCManager.RegisterModules();

            // Set the aplication to use portuguese culture
            LanguageService.SetCulture(AvailableCulture.Portuguese);

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(_container.GetInstance<MainForm>());
            Application.AutoMapperConfig.AutoMapperConfig.RegisterMapping();
            
        }
    }
}
