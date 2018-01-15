using System.Windows.Forms;
using GourmetGame.WindowsForms.Properties;
using GourmetGame.WindowsForms.Service.Interface;

namespace GourmetGame.WindowsForms.Service
{
    public class UserDisplayMessageService : IUserDisplayMessageService
    {
        private readonly IInputDialogBox _inputDialogBox;

        public UserDisplayMessageService(InputDialogBox inputDialogBox)
        {
            _inputDialogBox = inputDialogBox;
        }

        public DialogResult ShowAUserQuestion(string question)
        {
            return MessageBox.Show(question, Resources.TitleMessageBox, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public DialogResult ShowAUserInfo(string info)
        {
            return MessageBox.Show(info, Resources.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GetUserInput(string caption)
        {
            return _inputDialogBox.ShowInputDialog(caption);
        }
    }
}