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
    public partial class AlterStuInfoForm : Form
    {
        private Leader leader;
        private StuInfo stuInfo;
        private int select;
        private StuBaseInfoBLL stuBaseInfoBLL;
        public AlterStuInfoForm(Leader leader, StuInfo stuInfo, int select)
        {
            this.leader = leader;
            stuBaseInfoBLL = new StuBaseInfoBLL(leader);
            this.stuInfo = stuInfo;
            InitializeComponent();
            // 读取 StuInfo 信息并显示
            // 根据之前的选择设置能否编辑
            switch (select)
            {
                case 0: break;
                case 1:
                    StuFamgroupBox.Enabled = false;
                    StuSchgroupBox.Enabled = false;
                    break;
                case 2:
                    StuPergroupBox.Enabled = false;
                    StuSchgroupBox.Enabled = false;
                    break;
                case 3:
                    StuPergroupBox.Enabled = false;
                    StuFamgroupBox.Enabled = false;
                    break;
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
        private void AlterStuInfobutton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlterStuInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
