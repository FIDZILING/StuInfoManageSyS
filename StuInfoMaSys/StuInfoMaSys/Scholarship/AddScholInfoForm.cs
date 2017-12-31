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
    public partial class AddScholInfoForm : Form
    {
        private Leader leader;
        private ScholBLL scholBLL = new ScholBLL();
        /// <summary>
        /// 奖学金类型列表
        /// </summary>
        private DataTable typedataTable;
        public AddScholInfoForm(Leader leader)
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
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScholInfoForm_Load(object sender, EventArgs e)
        {
            TypecomboBox.ResetText();
            typedataTable = scholBLL.Find_AllType();
            for (int i = 0; i < typedataTable.Rows.Count; i++)
                TypecomboBox.Items.Add(typedataTable.Rows[i][1].ToString());
        }
        /// <summary>
        /// 添加奖学金信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScholInfobutton_Click(object sender, EventArgs e)
        {
            string StuNo = StuNotextBox.Text.Trim();
            if (StuNo.Length != 13)
            {
                MessageBox.Show("学号长度不符！");
                return;
            }
            if (TypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("未选择奖学金类型！");
                return;
            }
            if (LevelcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("未选择奖学金等级！");
                return;
            }
            string type = typedataTable.Rows[TypecomboBox.SelectedIndex][0].ToString();
            string level = LevelcomboBox.SelectedIndex.ToString();
            if (scholBLL.Add_ScholInfo(StuNo, type, level, dateTimePicker1.Value.Date))
            {
                if (MessageBox.Show("添加成功！") == DialogResult.OK)
                    this.Close();
            }
            else
                MessageBox.Show("添加失败！");
        }
    }
}
