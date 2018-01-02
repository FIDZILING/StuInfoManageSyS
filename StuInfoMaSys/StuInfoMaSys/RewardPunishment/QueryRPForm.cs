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

namespace StuInfoMaSys.RewardPunishment
{
    public partial class QueryRPForm : Form
    {
        /// <summary>
        /// 奖励字典SS
        /// </summary>
        private Dictionary<string, string> rewardSSdictionary = new Dictionary<string, string>
        {
            { "a", "国家级" },
            { "b", "省级" },
            { "c", "市级" },
            { "d", "校级" },
            { "e", "院级" },
            { "f", "年级" }
        };
        /// <summary>
        /// 处罚字典SS
        /// </summary>
        private Dictionary<string, string> punishSSdictionary = new Dictionary<string, string>
        {
            { "1", "留校查看" },
            { "2", "记过" },
            { "3", "严重警告" },
            { "4", "警告" },
            { "5", "学校通报批评" },
            { "6", "学院通报批评" },
            { "7", "年级通报批评" }
        };
        /// <summary>
        /// 类型字典SS
        /// </summary>
        private Dictionary<string, string> typeSSdictionary = new Dictionary<string, string>
        {
            { "1", "奖励" },
            { "2", "惩罚" }
        };
        /// <summary>
        /// 奖励字典IS
        /// </summary>
        private Dictionary<int, string> rewardISdictionary = new Dictionary<int, string>
        {
            { 0, "a" },
            { 1, "b" },
            { 2, "c" },
            { 3, "d" },
            { 4, "e" },
            { 5, "f" }
        };
        /// <summary>
        /// 处罚字典IS
        /// </summary>
        private Dictionary<int, string> punishISdictionary = new Dictionary<int, string>
        {
            { 0, "1" },
            { 1, "2" },
            { 2, "3" },
            { 3, "4" },
            { 4, "5" },
            { 5, "6" },
            { 6, "7" }
        };
        /// <summary>
        /// 类型字典IS
        /// </summary>
        private Dictionary<int, string> typeISdictionary = new Dictionary<int, string>
        {
            { 0, "1" },
            { 1, "2" }
        };
        /// <summary>
        /// 后备表
        /// </summary>
        DataTable dataTable;
        private RPBLL rpBLL = new RPBLL();
        private Leader leader;
        public QueryRPForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
            TypecomboBox.Items.Add("奖励");
            TypecomboBox.Items.Add("惩罚");
            // listview基本设置
            listView1.GridLines = false;
            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            listView1.FullRowSelect = true;
            listView1.Columns.Clear(); // 先清空，后加入
            listView1.Columns.Add("序号", 1 * listView1.Width / 13);
            listView1.Columns.Add("学号", 3 * listView1.Width / 13);
            listView1.Columns.Add("奖惩类型", 2 * listView1.Width / 13);
            listView1.Columns.Add("奖惩等级", 2 * listView1.Width / 13);
            listView1.Columns.Add("获得日期", 2 * listView1.Width / 13);
            listView1.Columns.Add("详细信息", 5 * listView1.Width / 13);
            dataTable = rpBLL.Find_AllRPInfo();
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
        /// 添加奖惩信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRPbutton_Click(object sender, EventArgs e)
        {
            AddRPForm addRPForm = new AddRPForm(leader)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addRPForm.Show();
        }
        /// <summary>
        /// 窗体加载
        /// 设置按钮权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRPForm_Load(object sender, EventArgs e)
        {
            // 权限
            if (leader.Identify == "3")
                AddRPbutton.Enabled = false;
            // 根据datatable 设置 listview
            listView1.BeginUpdate();
            listView1.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem
                {
                    Text = dataTable.Rows[i][0].ToString()
                };
                listViewItem.SubItems.Add(dataTable.Rows[i][1].ToString());
                listViewItem.SubItems.Add(typeSSdictionary[dataTable.Rows[i][2].ToString()]);
                if (dataTable.Rows[i][2].ToString() == "1")
                    listViewItem.SubItems.Add(rewardSSdictionary[dataTable.Rows[i][3].ToString()]);
                else
                    listViewItem.SubItems.Add(punishSSdictionary[dataTable.Rows[i][3].ToString()]);
                listViewItem.SubItems.Add(dataTable.Rows[i][4].ToString());
                listViewItem.SubItems.Add(dataTable.Rows[i][5].ToString());
                listView1.Items.Add(listViewItem);
            }
            listView1.EndUpdate();
        }
        /// <summary>
        /// 设置奖惩等级comboBox
        /// 并根据奖惩等级查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevelcomboBox.ResetText(); // 重设text
            LevelcomboBox.Items.Clear(); // 清空表单
            LevelcomboBox.Enabled = true;
            if (TypecomboBox.SelectedIndex == 0)
            {
                LevelcomboBox.Items.Add("国家级");
                LevelcomboBox.Items.Add("省级");
                LevelcomboBox.Items.Add("市级");
                LevelcomboBox.Items.Add("校级");
                LevelcomboBox.Items.Add("院级");
                LevelcomboBox.Items.Add("年级");
            }
            else
            {
                LevelcomboBox.Items.Add("留校查看");
                LevelcomboBox.Items.Add("记过");
                LevelcomboBox.Items.Add("严重警告");
                LevelcomboBox.Items.Add("警告");
                LevelcomboBox.Items.Add("学校通报批评");
                LevelcomboBox.Items.Add("学院通报批评");
                LevelcomboBox.Items.Add("年级通报批评");
            }
            dataTable = rpBLL.Find_RPInfoByRPType(typeISdictionary[TypecomboBox.SelectedIndex]);
            QueryRPForm_Load(sender, e);
        }
        /// <summary>
        /// 根据等级查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LevelcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypecomboBox.SelectedIndex == 0)
                dataTable = rpBLL.Find_RPInfoByRPLevel(rewardISdictionary[LevelcomboBox.SelectedIndex]);
            else
                dataTable = rpBLL.Find_RPInfoByRPLevel(punishISdictionary[LevelcomboBox.SelectedIndex]);
            QueryRPForm_Load(sender, e);
        }
        /// <summary>
        /// 根据学号查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRPbutton_Click(object sender, EventArgs e)
        {
            string stunum = StuNumtextBox.Text.Trim();
            if (stunum.Length != 0)
                dataTable = rpBLL.Find_RPInfoByStuNum(stunum);
            else
                dataTable = rpBLL.Find_AllRPInfo();
            TypecomboBox.ResetText();
            TypecomboBox.Items.Clear();
            LevelcomboBox.ResetText(); // 重设text
            LevelcomboBox.Items.Clear(); // 清空表单
            QueryRPForm_Load(sender, e);
        }
        /// <summary>
        /// 导出当前dataGridView到文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exportbutton_Click(object sender, EventArgs e)
        {
            // 从listview中导出到exdatatable
            DataTable exdataTable = new DataTable("奖惩信息");
            exdataTable.Columns.Add("编号", Type.GetType("System.String"));
            exdataTable.Columns.Add("学号", Type.GetType("System.String"));
            exdataTable.Columns.Add("奖惩类型", Type.GetType("System.String"));
            exdataTable.Columns.Add("奖惩等级", Type.GetType("System.String"));
            exdataTable.Columns.Add("获得日期", Type.GetType("System.String"));
            exdataTable.Columns.Add("详细信息", Type.GetType("System.String"));
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                DataRow dataRow = exdataTable.NewRow(); //创建新行
                dataRow["编号"] = listView1.Items[i].SubItems[0].Text;
                dataRow["学号"] = listView1.Items[i].SubItems[1].Text;
                dataRow["奖惩类型"] = listView1.Items[i].SubItems[2].Text;
                dataRow["奖惩等级"] = listView1.Items[i].SubItems[3].Text;
                dataRow["获得日期"] = listView1.Items[i].SubItems[4].Text;
                dataRow["详细信息"] = listView1.Items[i].SubItems[5].Text;
                exdataTable.Rows.Add(dataRow); // 添加行到表
            }
            if (Program.ToExcelFile(exdataTable))
                MessageBox.Show("导出成功！");
            else
                MessageBox.Show("导出失败");
        }
    }
}
