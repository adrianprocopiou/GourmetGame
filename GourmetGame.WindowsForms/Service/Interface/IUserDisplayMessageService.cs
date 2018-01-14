using System.Windows.Forms;

namespace GourmetGame.WindowsForms.Service.Interface
{
    public interface IUserDisplayMessageService
    {
        DialogResult ShowAUserQuestion(string question);
    }
}