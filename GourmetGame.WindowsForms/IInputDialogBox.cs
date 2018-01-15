namespace GourmetGame.WindowsForms
{
    public interface IInputDialogBox
    {
        /// <summary>
        /// Provide a input dialog box with text area to be filled by user
        /// </summary>
        /// <param name="caption"></param>
        /// <returns></returns>
        string ShowInputDialog(string caption);
    }
}