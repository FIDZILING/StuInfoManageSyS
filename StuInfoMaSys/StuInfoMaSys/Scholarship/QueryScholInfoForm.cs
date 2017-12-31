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

namespace StuInfoMaSys.Scholarship
{
    public partial class QueryScholInfoForm : Form
    {
        private Leader leader;
        private ScholBLL scholBLL = new ScholBLL();
        /// <summary>
        /// 奖学金类型列表
        /// </summary>
        private DataTable typedataTable;
        public QueryScholInfoForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Returnbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryScholInfobutton_Click(object sender, EventArgs e)
        {
            string No = StuNotextBox.Text.Trim();
            int type = ScholTypecomboBox.SelectedIndex; // 选择的奖学金类型序号
            if (!No.Equals(""))
            {
                this.dataGridView1.DataSource = scholBLL.Find_ScholInfoByStdNo(No);
            }
            else if (type != -1 && ScholTypecomboBox.Text != "")
            {
                string typeChar = typedataTable.Rows[type][0].ToString();
                this.dataGridView1.DataSource = scholBLL.Find_ScholInfoByScholType(typeChar);
            }
            else
            {
                QueryScholInfoForm_Load(sender, e);
            }
        }
        /// <summary>
        /// 添加奖学金
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
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryScholInfoForm_Load(object sender, EventArgs e)
        {
            // ScholTypecomboBox
            ScholTypecomboBox.ResetText(); // 重设text
            ScholTypecomboBox.Items.Clear(); // 清空表单
            typedataTable = scholBLL.Find_AllType();
            for (int i = 0; i < typedataTable.Rows.Count; i++)
                ScholTypecomboBox.Items.Add(typedataTable.Rows[i][1].ToString());
            ScholTypecomboBox.Items.Add("");
            // dataGridView
            this.dataGridView1.RowTemplate.Height = 30; // 行高
            // 颜色交替
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            dataGridView1.ReadOnly = true; // 设置只读
            this.dataGridView1.DataSource = scholBLL.Find_AllInfo();
        }
    }
}
