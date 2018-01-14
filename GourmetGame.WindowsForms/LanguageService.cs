using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace GourmetGame.WindowsForms
{
    /// <summary>
    ///     All available cultures for use in application
    /// </summary>
    public enum AvailableCulture
    {
        /// <summary>
        ///     Portuguese culture
        /// </summary>
        Portuguese,

        /// <summary>
        ///     English culture
        /// </summary>
        English
    }

    public static class LanguageService
    {

        private static void ChangeCulture(string culture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        }


        private static void UpdateControlsWithCurrentCulture(Control.ControlCollection controls,
            ComponentResourceManager resourceManager)
        {
            foreach (Control control in controls)
            {
                resourceManager.ApplyResources(control, control.Name, Thread.CurrentThread.CurrentCulture);
                UpdateControlsWithCurrentCulture(control.Controls, resourceManager);
            }
        }

        /// <summary>
        ///     Change the culture of application with the <paramref name="culture" /> specified
        /// </summary>
        /// <param name="culture">The culture to be used in application</param>
        public static void SetCulture(AvailableCulture culture)
        {
            switch (culture)
            {
                case AvailableCulture.Portuguese:
                    ChangeCulture("pt-BR");
                    break;
                case AvailableCulture.English:
                    ChangeCulture("en-US");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(culture), culture, null);
            }
        }

        /// <summary>
        ///     Refresh <paramref name="form"/> and all controls with current culture
        /// </summary>
        /// <param name="form">Form to be refreshed with current culture</param>
        public static void UpdateFormWithCurrentCulture(Form form)
        {
            var resourceManager = new ComponentResourceManager(form.GetType());
            resourceManager.ApplyResources(form, "$this");
            UpdateControlsWithCurrentCulture(form.Controls, resourceManager);
        }
    }
}