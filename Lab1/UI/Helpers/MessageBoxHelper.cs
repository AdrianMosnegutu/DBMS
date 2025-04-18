namespace Lab1.UI.Helpers
{
    using System.Windows.Forms;

    /// <summary>
    /// Provides utility methods for displaying message boxes to the user.
    /// </summary>
    internal static class MessageBoxHelper
    {
        /// <summary>
        /// Displays an informational message box with the specified title and message.
        /// </summary>
        /// <param name="title">The title of the message box.</param>
        /// <param name="message">The message to display in the message box.</param>
        public static void ShowInfoBox(string title, string message)
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Displays an error message box with the specified title and message.
        /// </summary>
        /// <param name="title">The title of the message box.</param>
        /// <param name="message">The message to display in the message box.</param>
        public static void ShowErrorBox(string title, string message)
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
