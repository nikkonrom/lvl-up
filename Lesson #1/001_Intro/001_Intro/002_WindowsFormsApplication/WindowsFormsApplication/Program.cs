using System;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // // Отображение окна формы Form1
            Application.Run(new Form1());
        }
    }
}
