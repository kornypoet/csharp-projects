using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Asg03
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
            LoginScreen loginScreen = new LoginScreen();
            if (loginScreen.ShowDialog() == DialogResult.OK)
            {                
                MainForm mainForm = new MainForm();
                mainForm.currentUser = loginScreen.bankUser;
                Application.Run(mainForm);
            }            
        }
    }
}
