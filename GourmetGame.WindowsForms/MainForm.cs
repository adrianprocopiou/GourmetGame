using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GourmetGame.WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
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
