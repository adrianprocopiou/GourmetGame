using System.Windows.Forms;

namespace GourmetGame.WindowsForms
{
    public partial class InputDialogBox : Form
    {
        public InputDialogBox()
        {
            InitializeComponent();
            buttonOk.Click += (sender, e) => { this.Close(); };
        }

        public string ShowInputDialog(string caption)
        {
            labelMessage.Text = caption;
            return this.ShowDialog() == DialogResult.OK? textBoxInputUser.Text : "";
        }
    }
}
