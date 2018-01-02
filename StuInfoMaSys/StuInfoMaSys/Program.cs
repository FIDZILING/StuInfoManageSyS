using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuInfoMaSys
{

    static class Program
    {
        public static Leader programleader;
        /// <summary>
        /// 导出到文件
        /// </summary>
        /// <param name="dataTable">数据源</param>
        public static void ToExcelFile(DataTable dataTable)
        {
            string con = "";
            foreach (DataColumn dc in dataTable.Columns)
            {
                con += dc.ColumnName + ",";
            }
            con = con.TrimEnd(',') + Environment.NewLine;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    con += dataTable.Rows[i][j].ToString().Replace("\n", " ").Replace("\r\n", " ").Replace(",", "，") + ",";
                }
                con = con.TrimEnd(',') + Environment.NewLine;
            }
            FileStream fs = new FileStream("C:\\test.xls", FileMode.Create);
            byte[] b = Encoding.GetEncoding("gb2312").GetBytes(con);
            fs.Write(b, 0, b.Length);
            fs.Close();
        }
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
