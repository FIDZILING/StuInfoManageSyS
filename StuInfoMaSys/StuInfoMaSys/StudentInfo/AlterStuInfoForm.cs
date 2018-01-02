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
        /// <summary>
        /// 民族数组
        /// </summary>
        private string[] nationstring =
        {
            "阿昌族",
            "白族",
            "保安族",
            "布朗族",
            "布依族",
            "藏族",
            "朝鲜族",
            "达斡尔族",
            "傣族",
            "德昂族",
            "东乡族",
            "侗族",
            "独龙族",
            "俄罗斯族",
            "鄂伦春族",
            "鄂温克族",
            "高山族",
            "哈尼族",
            "哈萨克族",
            "汉族",
            "赫哲族",
            "回族",
            "基诺族",
            "京族",
            "景颇族",
            "柯尔克孜族",
            "拉祜族",
            "黎族",
            "傈僳族",
            "珞巴族",
            "满族",
            "毛南族",
            "门巴族",
            "蒙古族",
            "苗族",
            "仫佬族",
            "纳西族",
            "怒族",
            "普米族",
            "羌族",
            "撒拉族",
            "畲族",
            "水族",
            "塔吉克族",
            "塔塔尔族",
            "土家族",
            "土族",
            "佤族",
            "维吾尔族",
            "乌兹别克族",
            "锡伯族",
            "瑶族",
            "彝族",
            "仡佬族",
            "裕固族",
            "壮族"
        };
        /// <summary>
        /// 政治面貌
        /// </summary>
        private string[] Symbolstring =
        {
            "共青团员",
            "中共党员",
            "中共预备党员",
            "群众",
            "其他"
        };
        /// <summary>
        /// 省份数组
        /// </summary>
        private string[] prostring =
        {
            "安徽省",
            "澳门",
            "北京市",
            "福建省",
            "甘肃省",
            "广东省",
            "广西",
            "贵州省",
            "海南省",
            "河北省",
            "河南省",
            "黑龙江省",
            "湖北省",
            "湖南省",
            "吉林省",
            "江苏省",
            "江西省",
            "辽宁省",
            "内蒙古",
            "宁夏",
            "青海省",
            "山东省",
            "山西省",
            "陕西省",
            "上海市",
            "四川省",
            "台湾省",
            "天津市",
            "西藏",
            "香港",
            "新疆",
            "云南省",
            "浙江省",
            "重庆市",
        };
        private Leader leader;
        private StuInfo stuInfo;
        private int select;
        private StuBaseInfoBLL stuBaseInfoBLL;
        public AlterStuInfoForm(Leader leader, StuInfo stuInfo, int select)
        {
            this.leader = leader;
            this.stuInfo = stuInfo;
            this.select = select;
            stuBaseInfoBLL = new StuBaseInfoBLL(leader);
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
        /// 修改按钮
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
            // 设置 comboBox 数据
            NationcomboBox.Items.Clear();
            NationcomboBox.Items.AddRange(nationstring);
            SymbolcomboBox.Items.Clear();
            SymbolcomboBox.Items.AddRange(Symbolstring);
            OriginProcomboBox.Items.Clear();
            OriginProcomboBox.Items.AddRange(prostring);
            HomeProcomboBox.Items.Clear();
            HomeProcomboBox.Items.AddRange(prostring);
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
            // 根据权限leader权限设置学院年级能否编辑
            if (leader.Identify == "2")
                CollegetextBox.Enabled = false;
            if (leader.Identify == "3")
            {
                CollegetextBox.Enabled = false;
                GradetextBox.Enabled = false;
            }
            #region 读取 StuInfo 信息并显示
            StuNoNameSexlabel.Text = "学号：" + stuInfo.StuNo + "姓名：" + stuInfo.StuName + "性别：" + stuInfo.Sex;
            NationcomboBox.Text = stuInfo.Nation;
            BirthdaydateTimePicker.Text = stuInfo.Birthday;
            SymbolcomboBox.Text = stuInfo.Symbol;
            TelNumtextBox.Text = stuInfo.TelNum;
            QQNumtextBox.Text = stuInfo.QQNum;
            IDNumtextBox.Text = stuInfo.IDNum;
            OriginProcomboBox.Text = stuInfo.OriginPro;
            OriginCitycomboBox.Text = stuInfo.OriginCity;
            OriginCountycomboBox.Text = stuInfo.OriginCounty;
            #endregion
        }
        /// <summary>
        /// 设置籍贯-市
        /// </summary>
        private void SetOriginCity()
        {
            OriginCitycomboBox.Items.Clear();
            DataTable dataTable = stuBaseInfoBLL.Back_City(OriginProcomboBox.Text);
            for (int i = 0; i < dataTable.Rows.Count; i++)
                OriginCitycomboBox.Items.Add(dataTable.Rows[i][0].ToString());
        }
        /// <summary>
        /// 设置籍贯-区/县
        /// </summary>
        private void SetOriginCounty()
        {
            OriginCountycomboBox.Items.Clear();
            DataTable dataTable = stuBaseInfoBLL.Back_Country(OriginCitycomboBox.Text);
            for (int i = 0; i < dataTable.Rows.Count; i++)
                OriginCountycomboBox.Items.Add(dataTable.Rows[i][0].ToString());
        }
        /// <summary>
        /// 设置家庭地址-市
        /// </summary>
        private void SetHomeCity()
        {
            HomeCitycomboBox.Items.Clear();
            DataTable dataTable = stuBaseInfoBLL.Back_City(HomeProcomboBox.Text);
            for (int i = 0; i < dataTable.Rows.Count; i++)
                HomeCitycomboBox.Items.Add(dataTable.Rows[i][0].ToString());
        }
        /// <summary>
        /// 设置家庭地址-区/县
        /// </summary>
        private void SetHomeCounty()
        {
            HomeCountycomboBox.Items.Clear();
            DataTable dataTable = stuBaseInfoBLL.Back_Country(HomeCitycomboBox.Text);
            for (int i = 0; i < dataTable.Rows.Count; i++)
                HomeCountycomboBox.Items.Add(dataTable.Rows[i][0].ToString());
        }
    }
}
