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
        public static bool ToExcelFile(DataTable dataTable)
        {
            // 文件选择器保存文件位置
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel97-2003工作簿|*.xls"
            };
            if (dataTable == null)
                return false;
            int rowNum = dataTable.Rows.Count;//需要导出的数据的行数
            int columnNum = dataTable.Columns.Count;//需要导出的数据的列数
            int rowIndex = 1;//起始行为第二行
            int columnIndex = 0;//起始列为第一列
            Microsoft.Office.Interop.Excel.Range range;//Excel的格式设置
            System.Reflection.Missing miss = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application
            {
                DisplayAlerts = true,// 在程序执行过程中使出现的警告框显示
                SheetsInNewWorkbook = 1
            };
            try
            {
                Microsoft.Office.Interop.Excel.Workbook xlBook = xlApp.Workbooks.Add(true);

                foreach (DataColumn dc in dataTable.Columns)             //将datatable的列名导入excel表的第一行
                {
                    columnIndex++;
                    xlApp.Cells[rowIndex, columnIndex] = dc.ColumnName;
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //将数据写入到Excel表中
                    for (int i = 0; i < rowNum; i++)
                    {
                        rowIndex++;
                        columnIndex = 0;
                        for (int j = 0; j < columnNum; j++)
                        {//按行写入数据
                            columnIndex++;
                            range = (Microsoft.Office.Interop.Excel.Range)xlApp.Cells[rowIndex, columnIndex];
                            range.NumberFormatLocal = "@";//写入到表中的数据格式以文本形式存在
                            xlApp.Cells[rowIndex, columnIndex] = dataTable.Rows[i][j].ToString();
                        }
                    }
                    //数据保存
                    xlBook.SaveAs(saveFileDialog.FileName, miss, miss, miss, miss, miss, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss, miss);
                    xlBook.Close(false, miss, miss);
                    xlApp.Quit();
                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                return false;
            }
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
