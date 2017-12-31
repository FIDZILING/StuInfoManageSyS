using Model;
using StuInfoMaSys.Club;
using StuInfoMaSys.Scholarship;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuInfoMaSys
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 领导者信息
        /// </summary>
        private Leader leader;

        public MainForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// 主窗体载入
        /// 根据身份设置功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (leader.Identify.Equals("2"))
            {
                WelcomeLabel.Text = "欢迎 " + leader.ID + " 校领导 " + leader.Name;
            }
            else if (leader.Identify.Equals("2"))
            {
                WelcomeLabel.Text = "欢迎 " + leader.ID + "" + leader.College + " 领导 " + leader.Name;
                AddStuPerInfobutton.Enabled = false;
                AddClubInfobutton.Enabled = false;
                AddScholTypebutton.Enabled = false;
                AddStuPerInfoToolStripMenuItem.Enabled = false;
                AddClubInfoToolStripMenuItem.Enabled = false;
                AddScholTypeToolStripMenuItem.Enabled = false;
            }
            else if (leader.Identify.Equals("3"))
            {
                WelcomeLabel.Text = "欢迎 " + leader.ID + "" + leader.College + " " + leader.Grade + " 辅导员 " + leader.Name;
                AddStuPerInfobutton.Enabled = false;
                AddClubInfobutton.Enabled = false;
                AddScholTypebutton.Enabled = false;
                AddStuPerInfoToolStripMenuItem.Enabled = false;
                AddClubInfoToolStripMenuItem.Enabled = false;
                AddScholTypeToolStripMenuItem.Enabled = false;

                AddScholInfobutton.Enabled = false;
                AddRPInfobutton.Enabled = false;
                AddScholInfoToolStripMenuItem.Enabled = false;
                AddRPInfoToolStripMenuItem.Enabled = false;
            }
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 添加奖学金类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScholTypebutton_Click(object sender, EventArgs e)
        {
            AddScholTypeForm addScholTypeForm = new AddScholTypeForm(this.leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addScholTypeForm.Show();
        }
        /// <summary>
        /// 添加奖学金类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScholTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScholTypeForm addScholTypeForm = new AddScholTypeForm(this.leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addScholTypeForm.Show();
        }
        /// <summary>
        /// 添加奖学金信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScholInfobutton_Click(object sender, EventArgs e)
        {
            AddScholInfoForm addScholInfoForm = new AddScholInfoForm(this.leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addScholInfoForm.Show();
        }
        /// <summary>
        /// 添加奖学金信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScholInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScholInfoForm addScholInfoForm = new AddScholInfoForm(this.leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addScholInfoForm.Show();
        }
        /// <summary>
        /// 查询奖学金信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryScholInfobutton_Click(object sender, EventArgs e)
        {
            QueryScholInfoForm queryScholInfoForm = new QueryScholInfoForm(this.leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            queryScholInfoForm.Show();
        }
        /// <summary>
        /// 查询奖学金信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryScholInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryScholInfoForm queryScholInfoForm = new QueryScholInfoForm(this.leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            queryScholInfoForm.Show();
        }
        /// <summary>
        /// 查询社团信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClubInfobutton_Click(object sender, EventArgs e)
        {
            QueryClubInfoForm queryClubInfoForm = new QueryClubInfoForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            queryClubInfoForm.Show();
        }
        /// <summary>
        /// 查询社团信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClubInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryClubInfoForm queryClubInfoForm = new QueryClubInfoForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            queryClubInfoForm.Show();
        }
        /// <summary>
        /// 添加社团信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClubInfobutton_Click(object sender, EventArgs e)
        {
            AddClubInfoForm addClubInfoForm = new AddClubInfoForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addClubInfoForm.Show();
        }
        /// <summary>
        /// 添加社团信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClubInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClubInfoForm addClubInfoForm = new AddClubInfoForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addClubInfoForm.Show();
        }
        /// <summary>
        /// 查询社团人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClubPeobutton_Click(object sender, EventArgs e)
        {
            QueryClubPeoForm queryClubPeoForm = new QueryClubPeoForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            queryClubPeoForm.Show();
        }
        /// <summary>
        /// 查询社团人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClubPeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryClubPeoForm queryClubPeoForm = new QueryClubPeoForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            queryClubPeoForm.Show();
        }
        /// <summary>
        /// 添加社团成员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClubPeobutton_Click(object sender, EventArgs e)
        {
            AddClubPeoForm addClubPeoForm = new AddClubPeoForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addClubPeoForm.Show();
        }
        /// <summary>
        /// 添加社团成员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClubPeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClubPeoForm addClubPeoForm = new AddClubPeoForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addClubPeoForm.Show();
        }
    }
}
