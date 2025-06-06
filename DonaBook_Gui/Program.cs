using System;
using System.Windows.Forms;
using DonaBook_Gui.Forms;

namespace DonaBook_Gui
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
