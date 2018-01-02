using Model;
using BLL;
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
    public partial class AddStuInfoForm : Form
    {
        private Leader leader;
        private StuBaseInfoBLL stuBaseInfoBLL;
        public AddStuInfoForm(Leader leader)
        {
            this.leader = leader;
            stuBaseInfoBLL = new StuBaseInfoBLL(leader);
            InitializeComponent();
            SchoolTypecomboBox.SelectedIndex = 0;
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
        /// 添加本科生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStuInfobutton_Click(object sender, EventArgs e)
        {
            string stunum = StuNumtextBox.Text.Trim();
            if (stunum.Length != 13)
            {
                MessageBox.Show("学号长度不符！");
                return;
            }
            string name = NametextBox.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("姓名不能为空！");
                return;
            }
            if (SexcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("未选择性别！");
                return;
            }
            if (SchoolTypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("未选择在校类型！");
                return;
            }
            if (stuBaseInfoBLL.Add_BaseStuInfo(stunum, name, SexcomboBox.SelectedItem.ToString(),
                SchoolTypecomboBox.SelectedIndex.ToString()))
                MessageBox.Show("添加成功！");
            else
                MessageBox.Show("添加失败！");
        }
    }
}
