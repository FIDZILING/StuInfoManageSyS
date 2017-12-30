using Model;
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
            addScholTypeForm.ShowDialog();
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
            addScholTypeForm.ShowDialog();
        }
    }
}
