using System;
using System.Windows.Forms;
using GourmetGame.Application.ViewModel;
using GourmetGame.WindowsForms.Service.Interface;

namespace GourmetGame.WindowsForms
{
    public partial class MainForm : Form
    {
        private readonly IMainFormService _service;
        public MainForm(IMainFormService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _service.StartGame();
        }

        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            LanguageService.SetCulture(AvailableCulture.English);
            LanguageService.UpdateFormWithCurrentCulture(this);
        }

        private void radioButtonPortuguese_CheckedChanged(object sender, EventArgs e)
        {
            LanguageService.SetCulture(AvailableCulture.Portuguese);
            LanguageService.UpdateFormWithCurrentCulture(this);
        }
    }
}