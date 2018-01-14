using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GourmetGame.Application.Service.Interface;
using GourmetGame.Application.ViewModel;

namespace GourmetGame.WindowsForms
{
    public partial class MainForm : Form
    {
        private readonly ICategoryAppService _categoryAppService;
        public MainForm(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var a = _categoryAppService.GetAll();
            _categoryAppService.Add(new CategoryViewModel(){Name = "João"});
            var b = _categoryAppService.GetAll();
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
