using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace StuInfoMaSys.Scholarship
{
    public partial class AddScholTypeForm : Form
    {
        private Leader leader;
        private ScholBLL scholBLL = new ScholBLL();
        public AddScholTypeForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
        }

        private void AddScholTypeForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowTemplate.Height = 30; // 行高
            // 颜色交替
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            dataGridView1.ReadOnly = true;
            try
            {
                this.dataGridView1.DataSource = scholBLL.Find_AllType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("网络错误！");
            }
        }
        /// <summary>
        /// 返回按钮 关闭此窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Returnbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 添加奖学金信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScholTypebutton_Click(object sender, EventArgs e)
        {
            string scholchar = ScholTypetextBox.Text.Trim();
            if (scholchar.Equals(""))
            {
                MessageBox.Show("请输入要添加的奖学金数据！");
                return;
            }
            if (MessageBox.Show("确定添加 " + scholchar + "？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (scholBLL.Add_ScholType(scholchar))
                    MessageBox.Show("添加成功！");
                else
                    MessageBox.Show("添加失败！");
                this.AddScholTypeForm_Load(sender, e); // 重新加载
            }
        }
    }
}
