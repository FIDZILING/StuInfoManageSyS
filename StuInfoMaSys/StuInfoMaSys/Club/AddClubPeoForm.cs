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
    public partial class AddClubPeoForm : Form
    {
        private ClubBLL clubBLL = new ClubBLL();
        private Leader leader;
        /// <summary>
        /// 社团名称列表
        /// </summary>
        private DataTable clubnamedataTable;
        public AddClubPeoForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClubPeoForm_Load(object sender, EventArgs e)
        {
            ClubNamecomboBox.ResetText();
            clubnamedataTable = clubBLL.Find_ALLInfo();
            for (int i = 0; i < clubnamedataTable.Rows.Count; i++)
                ClubNamecomboBox.Items.Add(clubnamedataTable.Rows[i][1].ToString());
        }
        /// <summary>
        /// 添加社团人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClubPeobutton_Click(object sender, EventArgs e)
        {
            string stunum = StuNumtextBox.Text.Trim();
            string clubpost = ClubPosttextBox.Text.Trim();
            if (ClubNamecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("未选择社团");
                return;
            }
            if (stunum.Length != 13)
            {
                MessageBox.Show("学号位数不对");
                return;
            }
            string clubnum = clubnamedataTable.Rows[ClubNamecomboBox.SelectedIndex][0].ToString();
            if (clubBLL.Add_ClubPeo(clubnum, stunum, clubpost))
            {
                if (MessageBox.Show("添加成功！") == DialogResult.OK)
                    this.Close();
            }
            else
                MessageBox.Show("添加失败！");
        }
    }
}
