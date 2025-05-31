using System;
using System.Windows.Forms;

namespace DonaBookGui
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          
            Application.Run(new Forms.Auth.LoginForm());
        }
    }
}
