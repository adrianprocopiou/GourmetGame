using System.Windows.Forms;

namespace GourmetGame.WindowsForms.Service.Interface
{
    public interface IUserDisplayMessageService
    {
        /// <summary>
        /// Show a confirmation dialog box with a question to user
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        DialogResult ShowAUserQuestion(string question);
        /// <summary>
        /// Show an informantion to user 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        DialogResult ShowAUserInfo(string info);
        /// <summary>
        /// Get the input text provided by user 
        /// </summary>
        /// <param name="caption"></param>
        /// <returns></returns>
        string GetUserInput(string caption);
    }
}