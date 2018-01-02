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
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="leader">领导用户信息</param>
        /// <param name="selectTab">选择的Tab</param>
        public QueryStuInfoForm(Leader leader, int selectTab)
        {
            this.leader = leader;
            stuBaseInfoBLL = new StuBaseInfoBLL(leader);
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
        /// 修改
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
    }
}
