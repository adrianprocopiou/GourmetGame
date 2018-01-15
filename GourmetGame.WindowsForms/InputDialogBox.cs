using System;
using System.Windows.Forms;

namespace GourmetGame.WindowsForms
{
    public partial class InputDialogBox : Form, IInputDialogBox
    {
        public InputDialogBox()
        {
            InitializeComponent();
            AcceptButton = buttonOk;
            CancelButton = buttonCancel;
        }

        public string ShowInputDialog(string caption)
        {
            textBoxInputUser.Text = string.Empty;
            labelMessage.Text = caption;
            return ShowDialog() == DialogResult.OK ? textBoxInputUser.Text : string.Empty;
        }

        protected override void OnShown(EventArgs e)
        {
            textBoxInputUser.Focus();
            base.OnShown(e);
        }
    }
}