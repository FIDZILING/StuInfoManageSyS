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
    public partial class QueryClubInfoForm : Form
    {
        private ClubBLL clubBLL = new ClubBLL();
        private Leader leader;
        public QueryClubInfoForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClubInfoForm_Load(object sender, EventArgs e)
        {
            // 按钮设置
            if (!leader.Identify.Equals("1"))
            {
                AddClubInfobutton.Enabled = false;
                AlterClubInfobutton.Enabled = false;
                dataGridView1.ReadOnly = true; // 设置只读
            }
            // dataGridView
            this.dataGridView1.RowTemplate.Height = 30; // 行高
            // 颜色交替
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            // 第一列第二列只读
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].ReadOnly = true;
            this.dataGridView1.DataSource = clubBLL.Find_ALLInfo();
        }
        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Returnbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///  查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClubInfobutton_Click(object sender, EventArgs e)
        {
            string clubname = ClubNametextBox.Text.Trim();
            if (clubname.Equals(""))
            {
                QueryClubInfoForm_Load(sender, e);
            }
            else
            {
                this.dataGridView1.DataSource = clubBLL.Find_ClubInfoByClubName(clubname);
            }
        }
        /// <summary>
        /// 添加按钮
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
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlterClubInfobutton_Click(object sender, EventArgs e)
        {

        }
    }
}
