using System;
using System.Windows.Forms;

namespace SmashText
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainUI();
            Application.Run(mainForm);
        }
    }
}