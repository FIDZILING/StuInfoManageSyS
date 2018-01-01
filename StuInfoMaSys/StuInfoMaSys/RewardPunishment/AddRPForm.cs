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
    public partial class AddRPForm : Form
    {
        /// <summary>
        /// 奖励字典
        /// </summary>
        private Dictionary<int, string> rewarddictionary = new Dictionary<int, string>
        {
            { 0, "a" },
            { 1, "b" },
            { 2, "c" },
            { 3, "d" },
            { 4, "e" },
            { 5, "f" }
        };
        /// <summary>
        /// 处罚字典
        /// </summary>
        private Dictionary<int, string> punishdictionary = new Dictionary<int, string>
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
        /// 类型字典
        /// </summary>
        private Dictionary<int, string> typedictionary = new Dictionary<int, string>
        {
            { 0, "1" },
            { 1, "2" }
        };
        private RPBLL rPBLL = new RPBLL();
        private Leader leader;
        public AddRPForm(Leader leader)
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
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRPbutton_Click(object sender, EventArgs e)
        {
            string StuNum = StuNumtextBox.Text.Trim();
            if (StuNum.Length != 13)
            {
                MessageBox.Show("学号长度不符！");
                return;
            }
            if (RPTypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("未选择奖惩类型！");
                return;
            }
            if (RPLevelcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("未选择奖惩等级！");
                return;
            }
            string info = InfotextBox.Text.Trim();
            if (info.Length == 0)
            {
                MessageBox.Show("未输入详细信息！");
                return;
            }
            string level;
            if (RPTypecomboBox.SelectedIndex == 0)
                level = rewarddictionary[RPTypecomboBox.SelectedIndex];
            else
                level = punishdictionary[RPTypecomboBox.SelectedIndex];
            if (rPBLL.Add_RPInfo(StuNum, typedictionary[RPTypecomboBox.SelectedIndex],
                level, dateTimePicker1.Value.Date, info))
            {
                if (MessageBox.Show("添加成功！") == DialogResult.OK)
                    this.Close();
            }
            else
                MessageBox.Show("添加失败！");

        }
        /// <summary>
        /// 根据选择的类型改变奖惩的等级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RPTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPLevelcomboBox.ResetText(); // 重设text
            RPLevelcomboBox.Items.Clear(); // 清空表单
            if (RPTypecomboBox.SelectedIndex == 0)
            {
                RPLevelcomboBox.Items.Add("国家级");
                RPLevelcomboBox.Items.Add("省级");
                RPLevelcomboBox.Items.Add("市级");
                RPLevelcomboBox.Items.Add("校级");
                RPLevelcomboBox.Items.Add("院级");
                RPLevelcomboBox.Items.Add("年级");
            }
            else
            {
                RPLevelcomboBox.Items.Add("留校查看");
                RPLevelcomboBox.Items.Add("记过");
                RPLevelcomboBox.Items.Add("严重警告");
                RPLevelcomboBox.Items.Add("警告");
                RPLevelcomboBox.Items.Add("学校通报批评");
                RPLevelcomboBox.Items.Add("学院通报批评");
                RPLevelcomboBox.Items.Add("年级通报批评");
            }
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRPForm_Load(object sender, EventArgs e)
        {
            RPTypecomboBox.ResetText(); // 重设text
            RPTypecomboBox.Items.Clear(); // 清空表单
            RPTypecomboBox.Items.Add("奖励");
            RPTypecomboBox.Items.Add("惩罚");
        }
    }
}
