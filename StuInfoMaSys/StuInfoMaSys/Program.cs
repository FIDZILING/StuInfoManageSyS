using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuInfoMaSys
{

    static class Program
    {
        public static Leader programleader;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm
            {
                StartPosition = FormStartPosition.CenterScreen
            }; // 登陆窗体
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(programleader));
            }

        }
    }
}
