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
    public partial class QueryStuInfoForm : Form
    {
        private Leader leader;
        private StuBaseInfoBLL stuBaseInfoBLL;
        private int startselect;
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="leader">领导用户信息</param>
        /// <param name="selectTab">选择的Tab</param>
        public QueryStuInfoForm(Leader leader, int selectTab)
        {
            this.leader = leader;
            stuBaseInfoBLL = new StuBaseInfoBLL(leader);
            startselect = selectTab;
            InitializeComponent();
            switch (selectTab) // 设置默认Tab
            {
                case 1:
                    tabControl1.SelectedTab = StuPertabPage; break;
                case 2:
                    tabControl1.SelectedTab = StuFamtabPage; break;
                case 3:
                    tabControl1.SelectedTab = StuSchtabPage; break;
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
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alterbutton_Click(object sender, EventArgs e)
        {
            #region 获取索引和选择的学号
            int select;
            string stuno;
            if (tabControl1.SelectedTab.Name == "StuPertabPage")
            {
                select = 1;
                stuno = StuPerdataGridView.CurrentRow.Cells[0].Value.ToString();
            }
            else if (tabControl1.SelectedTab.Name == "StuFamtabPage")
            {
                select = 2;
                stuno = StuFamdataGridView.CurrentRow.Cells[0].Value.ToString();
            }
            else if (tabControl1.SelectedTab.Name == "StuSchtabPage")
            {
                select = 3;
                stuno = StuSchdataGridView.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                select = 0;
                stuno = StuAlldataGridView.CurrentRow.Cells[0].Value.ToString();
            }
            #endregion

            // 获取要修改的学生信息并组装
            DataTable stuinfodataTable = stuBaseInfoBLL.Find_AllByStuNoNOVague(stuno);
            StuInfo stuInfo = new StuInfo
            {
                StuNo = stuinfodataTable.Rows[0][0].ToString(),
                StuName = stuinfodataTable.Rows[0][1].ToString(),
                SchoolType = stuinfodataTable.Rows[0][2].ToString(),
                Grade = stuinfodataTable.Rows[0][3].ToString(),
                College = stuinfodataTable.Rows[0][4].ToString(),
                Profession = stuinfodataTable.Rows[0][5].ToString(),
                Classes = stuinfodataTable.Rows[0][6].ToString(),
                DorArea = stuinfodataTable.Rows[0][7].ToString(),
                DorBuilding = stuinfodataTable.Rows[0][8].ToString(),
                DorNum = stuinfodataTable.Rows[0][9].ToString(),
                Sex = stuinfodataTable.Rows[0][10].ToString(),
                Nation = stuinfodataTable.Rows[0][11].ToString(),
                Birthday = stuinfodataTable.Rows[0][12].ToString(),
                Symbol = stuinfodataTable.Rows[0][13].ToString(),
                TelNum = stuinfodataTable.Rows[0][14].ToString(),
                QQNum = stuinfodataTable.Rows[0][15].ToString(),
                IDNum = stuinfodataTable.Rows[0][16].ToString(),
                OriginPro = stuinfodataTable.Rows[0][17].ToString(),
                OriginCity = stuinfodataTable.Rows[0][18].ToString(),
                OriginCounty = stuinfodataTable.Rows[0][19].ToString(),
                HighSchool = stuinfodataTable.Rows[0][20].ToString(),
                FamilyNum = stuinfodataTable.Rows[0][21].ToString(),
                HomePro = stuinfodataTable.Rows[0][22].ToString(),
                HomeCity = stuinfodataTable.Rows[0][23].ToString(),
                HomeCounty = stuinfodataTable.Rows[0][24].ToString(),
                HomeOther = stuinfodataTable.Rows[0][25].ToString(),
                FaName = stuinfodataTable.Rows[0][26].ToString(),
                FaTelNum = stuinfodataTable.Rows[0][27].ToString(),
                FaIncome = stuinfodataTable.Rows[0][28].ToString(),
                MaName = stuinfodataTable.Rows[0][29].ToString(),
                MaTelNum = stuinfodataTable.Rows[0][30].ToString(),
                MaIncome = stuinfodataTable.Rows[0][31].ToString(),
                OutSchool = stuinfodataTable.Rows[0][32].ToString()
            };
            // new Form
            AlterStuInfoForm alterStuInfoForm = new AlterStuInfoForm(leader, stuInfo, select)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            alterStuInfoForm.Show();
        }
        /// <summary>
        /// Tab选择时显示dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "StuPertabPage")
            {
                PergroupBox.Enabled = true;
                FamgroupBox.Enabled = false;
                SchgroupBox.Enabled = false;
                StuPerdataGridView.DataSource = stuBaseInfoBLL.Find_PerStuInfo();
            }
            else if (tabControl1.SelectedTab.Name == "StuFamtabPage")
            {
                PergroupBox.Enabled = false;
                FamgroupBox.Enabled = true;
                SchgroupBox.Enabled = false;
                StuFamdataGridView.DataSource = stuBaseInfoBLL.Find_FamStuInfo();
            }
            else if (tabControl1.SelectedTab.Name == "StuSchtabPage")
            {
                PergroupBox.Enabled = false;
                FamgroupBox.Enabled = false;
                SchgroupBox.Enabled = true;
                StuSchdataGridView.DataSource = stuBaseInfoBLL.Find_SchStuInfo();
            }
            else
            {
                PergroupBox.Enabled = true;
                FamgroupBox.Enabled = true;
                SchgroupBox.Enabled = true;
                StuAlldataGridView.DataSource = stuBaseInfoBLL.Find_ALLStuInformation();
            }
        }

        private void QueryStuInfoForm_Load(object sender, EventArgs e)
        {
            #region dataGridView 设置
            StuPerdataGridView.RowTemplate.Height = 30; // 行高
            // 颜色交替
            StuPerdataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            StuPerdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            StuPerdataGridView.ReadOnly = true; // 设置只读
            StuFamdataGridView.RowTemplate.Height = 30; // 行高
            // 颜色交替
            StuFamdataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            StuFamdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            StuFamdataGridView.ReadOnly = true; // 设置只读
            StuSchdataGridView.RowTemplate.Height = 30; // 行高
            // 颜色交替
            StuSchdataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            StuSchdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            StuSchdataGridView.ReadOnly = true; // 设置只读
            StuAlldataGridView.RowTemplate.Height = 30; // 行高
            // 颜色交替
            StuAlldataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            StuAlldataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 254, 254);
            StuAlldataGridView.ReadOnly = true; // 设置只读
            #endregion
            // 显示默认Tab中的datagridview
            switch (startselect)
            {
                case 1:
                    StuPerdataGridView.DataSource = stuBaseInfoBLL.Find_PerStuInfo();
                    FamgroupBox.Enabled = false;
                    SchgroupBox.Enabled = false;
                    break;
                case 2:
                    StuFamdataGridView.DataSource = stuBaseInfoBLL.Find_FamStuInfo();
                    PergroupBox.Enabled = false;
                    SchgroupBox.Enabled = false;
                    break;
                case 3:
                    StuSchdataGridView.DataSource = stuBaseInfoBLL.Find_SchStuInfo();
                    PergroupBox.Enabled = false;
                    FamgroupBox.Enabled = false;
                    break;
            }
        }
        /// <summary>
        /// 导出当前到文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exportbutton_Click(object sender, EventArgs e)
        {
            DataTable dataTable;
            if (tabControl1.SelectedTab.Name == "StuPertabPage")
                dataTable = (StuPerdataGridView.DataSource as DataTable);
            else if (tabControl1.SelectedTab.Name == "StuFamtabPage")
                dataTable = (StuFamdataGridView.DataSource as DataTable);
            else if (tabControl1.SelectedTab.Name == "StuSchtabPage")
                dataTable = (StuSchdataGridView.DataSource as DataTable);
            else
                dataTable = (StuAlldataGridView.DataSource as DataTable);
            if (Program.ToExcelFile(dataTable))
                MessageBox.Show("导出成功！");
            else
                MessageBox.Show("导出失败");
        }
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryStubutton_Click(object sender, EventArgs e)
        {
            string stuno = StuNumtextBox.Text.Trim();

            string sex = "";
            if (SexcomboBox.SelectedIndex != -1)
                sex = SexcomboBox.SelectedItem.ToString();
            string nation = NationtextBox.Text.Trim();
            string symbol = "";
            if (SymbolcomboBox.SelectedIndex != -1)
                symbol = SymbolcomboBox.SelectedItem.ToString();
            string originPro = OriginProtextBox.Text.Trim();

            string homePro = HomeProtextBox.Text.Trim();

            string schooltype = "";
            if (SchoolTypecomboBox.SelectedIndex != -1 && SchoolTypecomboBox.SelectedIndex != 0)
                schooltype = (SchoolTypecomboBox.SelectedIndex - 1).ToString();
            string grade = GradetextBox.Text.Trim();
            string college = CollegetextBox.Text.Trim();
            string profession = ProfessiontextBox.Text.Trim();
            string classes = ClasstextBox.Text.Trim();
            if (tabControl1.SelectedTab.Name == "StuPertabPage")
            {
                StuPerdataGridView.DataSource = stuBaseInfoBLL.Find_PerStuBySomethings(stuno, sex, nation, symbol, originPro);
            }
            else if (tabControl1.SelectedTab.Name == "StuFamtabPage")
            {
                StuFamdataGridView.DataSource = stuBaseInfoBLL.Find_FamStuBySomethings(stuno, homePro);
            }
            else if (tabControl1.SelectedTab.Name == "StuSchtabPage")
            {
                StuSchdataGridView.DataSource = stuBaseInfoBLL.Find_SchStuBySomethings(stuno, schooltype, grade,
                    college, profession, classes);
            }
            else
            {
                StuAlldataGridView.DataSource = stuBaseInfoBLL.Find_AllStuBySomethings(stuno, sex, nation, symbol, originPro,
                    homePro, schooltype, grade, college, profession, classes);
            }
        }
    }
}
