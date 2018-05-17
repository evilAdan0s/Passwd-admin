using System;
using System.Windows.Forms;

namespace PwdMgr.WUI
{

    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginF login = new LoginF();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                login.Dispose();
                login.Close();
                Application.Run(new MainF());
            }
        }
    }
}
