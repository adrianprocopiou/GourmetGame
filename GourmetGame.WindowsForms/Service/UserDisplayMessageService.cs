using System.Windows.Forms;
using GourmetGame.WindowsForms.Service.Interface;

namespace GourmetGame.WindowsForms.Service
{
    public class UserDisplayMessageService : IUserDisplayMessageService
    {
        public DialogResult ShowAUserQuestion(string question)
        {
            return MessageBox.Show(question, Properties.Resources.TitleMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult ShowAUserInfo(string info)
        {
            return MessageBox.Show(info, Properties.Resources.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}