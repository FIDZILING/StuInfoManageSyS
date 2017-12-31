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
    public partial class QueryClubPeoForm : Form
    {
        private ClubBLL clubBLL = new ClubBLL();
        private Leader leader;
        public QueryClubPeoForm(Leader leader)
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
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClubPeoForm_Load(object sender, EventArgs e)
        {
            // 按钮设置
            if (leader.Identify.Equals("3"))
            {
                AddClubPeobutton.Enabled = false;
                AlterClubPeobutton.Enabled = false;
                DeleteClubPeobutton.Enabled = false;
                dataGridView1.ReadOnly = true; // 设置只读
            }
            // dataGridView
            dataGridView1.RowTemplate.Height = 30; // 行高
            // 颜色交替
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            // 第一列、第二列、第三列只读
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.DataSource = clubBLL.Find_ALLInfo();
        }
        /// <summary>
        /// 添加成员信息
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
        /// 删除选择的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteClubPeobutton_Click(object sender, EventArgs e)
        {
            int seIndex = dataGridView1.CurrentCell.RowIndex;
            if (MessageBox.Show("确认删除 " + dataGridView1.Rows[seIndex].Cells[2].Value.ToString() + " 在 " +
                dataGridView1.Rows[seIndex].Cells[1].Value.ToString() + " 的信息？",
                "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clubBLL.DEL_ClubPeoByID(dataGridView1.Rows[seIndex].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("删除成功！");
                    this.QueryClubPeoForm_Load(sender, e);
                }
                else
                    MessageBox.Show("删除失败！");
            }
        }
        /// <summary>
        /// 修改选择的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlterClubPeobutton_Click(object sender, EventArgs e)
        {
            int seIndex = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[seIndex].Cells[3].Value.ToString() == "")
            {
                MessageBox.Show("请输入第 " + (seIndex + 1).ToString() + "行数据");
                return;
            }
            if (MessageBox.Show("确认修改 " + dataGridView1.Rows[seIndex].Cells[2].Value.ToString() + " 在 " +
                dataGridView1.Rows[seIndex].Cells[1].Value.ToString() + " 的职务为 " +
                dataGridView1.Rows[seIndex].Cells[3].Value.ToString(), "提示", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clubBLL.Change_ClubPeoByID(dataGridView1.Rows[seIndex].Cells[0].Value.ToString(),
                    dataGridView1.Rows[seIndex].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("修改成功！");
                    this.QueryClubPeoForm_Load(sender, e);
                }
                else
                    MessageBox.Show("修改失败！");
            }
        }
        /// <summary>
        /// 查询选择的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClubPeobutton_Click(object sender, EventArgs e)
        {
            string clubname = ClubNametextBox.Text.Trim();
            string stunum = StuNumtextBox.Text.Trim();
            if (clubname != "")
            {
                this.dataGridView1.DataSource = clubBLL.Find_ClubPeoByClubName(clubname);
            }
            else if (stunum != "")
            {
                dataGridView1.DataSource = clubBLL.Find_ClubPeoByStuNo(stunum);
            }
            else
                QueryClubPeoForm_Load(sender, e);
        }
    }
}
