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

namespace StuInfoMaSys.Club
{
    public partial class AddClubInfoForm : Form
    {
        private ClubBLL clubBLL = new ClubBLL();
        private Leader leader;
        public AddClubInfoForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
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
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClubInfobutton_Click(object sender, EventArgs e)
        {
            string clubname = ClubNametextBox.Text.Trim();
            string teacher = TeachtextBox.Text.Trim();
            string teachertel = TeachTeltextBox.Text.Trim();
            if (clubname == "")
            {
                MessageBox.Show("请输入社团名称！");
                return;
            }
            if (teachertel.Length != 0 && teachertel.Length != 11)
            {
                MessageBox.Show("电话号码位数不对！");
                return;
            }
            if (MessageBox.Show("确认添加 " + clubname + ", 指导老师为：" + teacher + ", 联系电话为：" + teachertel + "？",
                "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clubBLL.Add_ClubInfo(clubname, teacher, teachertel))
                {
                    if (MessageBox.Show("添加成功！") == DialogResult.OK)
                        this.Close();
                }
                else
                    MessageBox.Show("添加失败！");
            }
        }
    }
}
