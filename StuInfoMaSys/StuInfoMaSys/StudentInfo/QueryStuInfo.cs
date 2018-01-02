using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuInfoMaSys.StudentInfo
{
    public partial class QueryStuInfoForm : Form
    {
        private Leader leader;
        private StuBaseInfoBLL stuBaseInfoBLL;
        private int startselect;
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="leader">领导用户信息</param>
        /// <param name="selectTab">选择的Tab</param>
        public QueryStuInfoForm(Leader leader, int selectTab)
        {
            this.leader = leader;
            stuBaseInfoBLL = new StuBaseInfoBLL(leader);
            startselect = selectTab;
            InitializeComponent();
            switch (selectTab) // 设置默认Tab
            {
                case 1:
                    tabControl1.SelectedTab = StuPertabPage; break;
                case 2:
                    tabControl1.SelectedTab = StuFamtabPage; break;
                case 3:
                    tabControl1.SelectedTab = StuSchtabPage; break;
            }
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Returnbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alterbutton_Click(object sender, EventArgs e)
        {
            int select = 0;
            if (tabControl1.SelectedTab.Name == "StuPertabPage")
                select = 1;
            else if (tabControl1.SelectedTab.Name == "StuFamtabPage")
                select = 2;
            else if (tabControl1.SelectedTab.Name == "StuSchtabPage")
                select = 3;
            StuInfo stuInfo = new StuInfo();
            AlterStuInfoForm alterStuInfoForm = new AlterStuInfoForm(leader, stuInfo, select)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            alterStuInfoForm.Show();
        }
        /// <summary>
        /// Tab选择时显示dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "StuPertabPage")
                StuPerdataGridView.DataSource = stuBaseInfoBLL.Find_PerStuInfo();
            else if (tabControl1.SelectedTab.Name == "StuFamtabPage")
                StuFamdataGridView.DataSource = stuBaseInfoBLL.Find_FamStuInfo();
            else if (tabControl1.SelectedTab.Name == "StuSchtabPage")
                StuSchdataGridView.DataSource = stuBaseInfoBLL.Find_SchStuInfo();
            else
                StuAlldataGridView.DataSource = stuBaseInfoBLL.Find_ALLStuInformation();
        }

        private void QueryStuInfoForm_Load(object sender, EventArgs e)
        {
            #region dataGridView 设置
            StuPerdataGridView.RowTemplate.Height = 30; // 行高
            // 颜色交替
            StuPerdataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            StuPerdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            StuPerdataGridView.ReadOnly = true; // 设置只读
            StuFamdataGridView.RowTemplate.Height = 30; // 行高
            // 颜色交替
            StuFamdataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            StuFamdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            StuFamdataGridView.ReadOnly = true; // 设置只读
            StuSchdataGridView.RowTemplate.Height = 30; // 行高
            // 颜色交替
            StuSchdataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            StuSchdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            StuSchdataGridView.ReadOnly = true; // 设置只读
            StuAlldataGridView.RowTemplate.Height = 30; // 行高
            // 颜色交替
            StuAlldataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            StuAlldataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            StuAlldataGridView.ReadOnly = true; // 设置只读
            #endregion
            switch (startselect) // 显示默认Tab中的datagridview
            {
                case 1:
                    StuPerdataGridView.DataSource = stuBaseInfoBLL.Find_PerStuInfo(); break;
                case 2:
                    StuFamdataGridView.DataSource = stuBaseInfoBLL.Find_FamStuInfo(); break;
                case 3:
                    StuSchdataGridView.DataSource = stuBaseInfoBLL.Find_SchStuInfo(); break;
            }
        }
    }
}
