using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace BLL
{
    public class StuBaseInfoBLL
    {
        private StuBaseInfoDAL stuBaseInfoDAL = new DAL.StuBaseInfoDAL();
        private Leader leader;
        public StuBaseInfoBLL(Leader leader)
        {
            this.leader = leader;
        }

        /// <summary>
        /// 查找函数使用的权限判断
        /// </summary>
        /// <param name="Power">权限</param>
        /// <returns></returns>
        private StringBuilder PowerInFind(StringBuilder Power)
        {
            if (leader.Identify == "1")
                Power.Append(" where dbo.StudentBaseInformation.StuNo like '%_%'");
            else if (leader.Identify == "2")
            {
                Power.Append(" where dbo.StudentBaseInformation.College='");
                Power.Append(leader.College);
                Power.Append("'");
            }
            else if (leader.Identify == "3")
            {
                Power.Append(" where dbo.StudentBaseInformation.College='");
                Power.Append(leader.College);
                Power.Append("' and dbo.StudentBaseInformation.Grade='");
                Power.Append(leader.Grade);
                Power.Append("'");
            }
            return Power;
        }

        /// <summary>
        /// 查找本科生所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_ALLStuInformation()
        {
            StringBuilder Power = new StringBuilder();
            Power = PowerInFind(Power);
            return stuBaseInfoDAL.Find_ALLStuInformation(Power);
        }

        /// <summary>
        /// 查找本科生家庭信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_FamStuInfo()
        {
            StringBuilder Power = new StringBuilder();
            Power = PowerInFind(Power);
            return stuBaseInfoDAL.Find_FamStuInfo(Power);
        }

        /// <summary>
        /// 查找本科生个人信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_PerStuInfo()
        {
            StringBuilder Power = new StringBuilder();
            Power = PowerInFind(Power);
            return stuBaseInfoDAL.Find_PerStuInfo(Power);
        }

        /// <summary>
        /// 查找本科生在校信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_SchStuInfo()
        {
            StringBuilder Power = new StringBuilder();
            Power = PowerInFind(Power);
            return stuBaseInfoDAL.Find_SchStuInfo(Power);
        }

        /// <summary>
        /// 查找寝室ID，返回(string)ID
        /// </summary>
        /// <param name="DorArea">寝室区域</param>
        /// <param name="DorBuilding">寝室楼</param>
        /// <param name="DorNum">寝室号码</param>
        /// <returns></returns>
        public string Find_DorID(string DorArea, string DorBuilding, string DorNum)
        {
            return stuBaseInfoDAL.Find_DorID(DorArea, DorBuilding, DorNum);
        }

        /// <summary>
        /// 添加本科生基本信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="StuName">姓名</param>
        /// <param name="SchoolType">在校状态</param>
        /// <param name="Sex">性别</param>
        /// <returns></returns>
        public bool Add_BaseStuInfo(string StuNo, string StuName, string SchoolType, string Sex)
        {
            return stuBaseInfoDAL.Add_BaseStuInfo(StuNo, StuName, SchoolType, Sex);
        }

        /// <summary>
        /// 本科生信息全部修改！
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="FamilyNum">家庭人口数</param>
        /// <param name="HomePro">家庭地址-省</param>
        /// <param name="HomeCity">家庭地址-市</param>
        /// <param name="HomeCounty">家庭地址-区/县</param>
        /// <param name="HomeOther">家庭地址-详细</param>
        /// <param name="FaName">父亲姓名</param>
        /// <param name="FaTelNum">父亲电话</param>
        /// <param name="FaIncome">父亲收入</param>
        /// <param name="MaName">母亲姓名</param>
        /// <param name="MaTelNum">母亲电话</param>
        /// <param name="MaIncome">母亲收入</param>
        /// <param name="Nation">民族</param>
        /// <param name="Birthday">出生日期</param>
        /// <param name="Symbol">政治面貌</param>
        /// <param name="TelNum">电话号码</param>
        /// <param name="QQNum">QQ号码</param>
        /// <param name="IDNum">身份证号码</param>
        /// <param name="OriginPro">籍贯-省</param>
        /// <param name="OriginCity">籍贯-市</param>
        /// <param name="OriginCounty">籍贯-区/县</param>
        /// <param name="HighSchool">毕业高中</param>
        /// <param name="SchoolType">在校类别</param>
        /// <param name="Grade">年级</param>
        /// <param name="College">学院</param>
        /// <param name="Profession">专业</param>
        /// <param name="Classes">班级</param>
        /// <param name="DropNum">寝室编号</param>
        /// <param name="OutSchool">出校信息</param>
        /// <returns></returns>
        public bool Change_AllStuInfo(string StuNo, string FamilyNum, string HomePro, string HomeCity, string HomeCounty, string HomeOther, string FaName, string FaTelNum, string FaIncome, string MaName, string MaTelNum, string MaIncome,
            string Nation, DateTime Birthday, string Symbol, string TelNum, string QQNum, string IDNum, string OriginPro, string OriginCity, string OriginCounty, string HighSchool,
             string SchoolType, string Grade, string College, string Profession, string Classes, string DropNum, string OutSchool)
        {
            if (stuBaseInfoDAL.Change_FamStuInfo(StuNo, FamilyNum, HomePro, HomeCity, HomeCounty, HomeOther, FaName, FaTelNum, FaIncome, MaName, MaTelNum, MaIncome) == true
                && stuBaseInfoDAL.Change_PerStuInfo(StuNo, Nation, Birthday, Symbol, TelNum, QQNum, IDNum, OriginPro, OriginCity, OriginCounty, HighSchool) == true
                && stuBaseInfoDAL.Change_SchStuInfo(StuNo, SchoolType, Grade, College, Profession, Classes, DropNum, OutSchool) == true)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改学生家庭信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="FamilyNum">家庭人口数</param>
        /// <param name="HomePro">家庭地址-省</param>
        /// <param name="HomeCity">家庭地址-市</param>
        /// <param name="HomeCounty">家庭地址-区/县</param>
        /// <param name="HomeOther">家庭地址-详细</param>
        /// <param name="FaName">父亲姓名</param>
        /// <param name="FaTelNum">父亲电话</param>
        /// <param name="FaIncome">父亲收入</param>
        /// <param name="MaName">母亲姓名</param>
        /// <param name="MaTelNum">母亲电话</param>
        /// <param name="MaIncome">母亲收入</param>
        /// <returns></returns>
        public bool Change_FamStuInfo(string StuNo, string FamilyNum, string HomePro, string HomeCity, string HomeCounty, string HomeOther,
            string FaName, string FaTelNum, string FaIncome, string MaName, string MaTelNum, string MaIncome)
        {
            return stuBaseInfoDAL.Change_FamStuInfo(StuNo, FamilyNum, HomePro, HomeCity, HomeCounty, HomeOther, FaName, FaTelNum, FaIncome, MaName, MaTelNum, MaIncome);
        }

        /// <summary>
        /// 修改学生个人信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="Nation">民族</param>
        /// <param name="Birthday">出生日期</param>
        /// <param name="Symbol">政治面貌</param>
        /// <param name="TelNum">电话号码</param>
        /// <param name="QQNum">QQ号码</param>
        /// <param name="IDNum">身份证号码</param>
        /// <param name="OriginPro">籍贯-省</param>
        /// <param name="OriginCity">籍贯-市</param>
        /// <param name="OriginCounty">籍贯-区/县</param>
        /// <param name="HighSchool">毕业高中</param>
        /// <returns></returns>
        public bool Change_PerStuInfo(string StuNo, string Nation, DateTime Birthday, string Symbol, string TelNum,
            string QQNum, string IDNum, string OriginPro, string OriginCity, string OriginCounty, string HighSchool)
        {
            return stuBaseInfoDAL.Change_PerStuInfo(StuNo, Nation, Birthday, Symbol, TelNum, QQNum, IDNum, OriginPro, OriginCity, OriginCounty, HighSchool);
        }

        /// <summary>
        /// 修改学生在校信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="SchoolType">在校类别</param>
        /// <param name="Grade">年级</param>
        /// <param name="College">学院</param>
        /// <param name="Profession">专业</param>
        /// <param name="Classes">班级</param>
        /// <param name="DropNum">寝室编号</param>
        /// <param name="OutSchool">出校信息</param>
        /// <returns></returns>
        public bool Change_SchStuInfo(string StuNo, string SchoolType, string Grade, string College,
            string Profession, string Classes, string DropNum, string OutSchool)
        {
            return stuBaseInfoDAL.Change_SchStuInfo(StuNo, SchoolType, Grade, College, Profession, Classes, DropNum, OutSchool);
        }

        /// <summary>
        /// 通过省调用到市
        /// </summary>
        /// <param name="Pro">市</param>
        /// <returns></returns>
        public DataTable Back_City(string Pro)
        {
            return stuBaseInfoDAL.Back_City(Pro);
        }

        /// <summary>
        /// 通过市调用到区/县
        /// </summary>
        /// <param name="City">市</param>
        /// <returns></returns>
        public DataTable Back_Country(string City)
        {
            return stuBaseInfoDAL.Back_Country(City);
        }

        /// <summary>
        /// 查找寝室地区
        /// </summary>
        /// <returns></returns>
        public DataTable Back_DorArea()
        {
            return stuBaseInfoDAL.Back_DorArea();
        }

        /// <summary>
        /// 通过寝室地区查找寝室楼栋
        /// </summary>
        /// <param name="DorArea">寝室地区</param>
        /// <returns></returns>
        public DataTable Back_DorBuilding(string DorArea)
        {
            return stuBaseInfoDAL.Back_DorBuilding(DorArea);
        }

        /// <summary>
        /// 通过寝室楼栋查找寝室号
        /// </summary>
        /// <param name="DorBuilding">寝室楼栋</param>
        /// <returns></returns>
        public DataTable Back_DorNum(string DorBuilding)
        {
            return stuBaseInfoDAL.Back_DorNum(DorBuilding);
        }

        /// <summary>
        /// 通过学号查找本科生所有信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <returns></returns>
        public DataTable Find_AllByStuNoNOVague(string StuNo)
        {
            return stuBaseInfoDAL.Find_AllByStuNoNOVague(StuNo);
        }

        /// <summary>
        /// 通过学号、性别、民族、政治面貌、籍贯-省查找本科生个人信息（模糊查询）
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="Sex">性别</param>
        /// <param name="Nation">民族</param>
        /// <param name="Symbol">政治面貌</param>
        /// <param name="OriginPro">籍贯-省</param>
        /// <returns></returns>
        public DataTable Find_PerStuBySomethings(string StuNo, string Sex, string Nation, string Symbol, string OriginPro)
        {
            StringBuilder Power = new StringBuilder();
            Power = PowerInFind(Power);
            if (StuNo == "") StuNo = "_";
            if (Sex == "") Sex = "_";
            if (Nation == "") Nation = "_";
            if (Symbol == "") Symbol = "_";
            if (OriginPro == "") OriginPro = "_";
            StuNo = "%" + StuNo + "%";
            Sex = "%" + Sex + "%";
            Nation = "%" + Nation + "%";
            Symbol = "%" + Symbol + "%";
            OriginPro = "%" + OriginPro + "%";
            return stuBaseInfoDAL.Find_PerStuBySomethings(Power, StuNo, Sex, Nation, Symbol, OriginPro);
        }

        /// <summary>
        /// 通过学号、住址-省查询本科生家庭信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="HomePro">住址-省</param>
        /// <returns></returns>
        public DataTable Find_FamStuBySomethings(string StuNo, string HomePro)
        {
            StringBuilder Power = new StringBuilder();
            Power = PowerInFind(Power);
            if (StuNo == "") StuNo = "_";
            if (HomePro == "") HomePro = "_";
            StuNo = "%" + StuNo + "%";
            HomePro = "%" + HomePro + "%";
            return stuBaseInfoDAL.Find_FamStuBySomethings(Power, StuNo, HomePro);
        }

        /// <summary>
        /// 通过学号、在校状态（类型）、年级、学院、专业、班级查找本科生在校信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="SchoolType">在校状态（类型）</param>
        /// <param name="Grade">年级</param>
        /// <param name="College">学院</param>
        /// <param name="Profession">专业</param>
        /// <param name="Classes">班级</param>
        /// <returns></returns>
        public DataTable Find_SchStuBySomethings(string StuNo, string SchoolType, string Grade, string College, string Profession, string Classes)
        {
            StringBuilder Power = new StringBuilder();
            Power = PowerInFind(Power);
            if (StuNo == "") StuNo = "_";
            if (SchoolType == "") SchoolType = "_";
            if (Grade == "") Grade = "_";
            if (College == "") College = "_";
            if (Profession == "") Profession = "_";
            if (Classes == "") Classes = "_";
            StuNo = "%" + StuNo + "%";
            SchoolType = "%" + SchoolType + "%";
            Grade = "%" + Grade + "%";
            College = "%" + College + "%";
            Profession = "%" + Profession + "%";
            Classes = "%" + Classes + "%";
            return stuBaseInfoDAL.Find_SchStuBySomethings(Power, StuNo, SchoolType, Grade, College, Profession, Classes);
        }

        /// <summary>
        /// 通过超级多的信息来查找本科生所有信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="Sex">性别</param>
        /// <param name="Nation">民族</param>
        /// <param name="Symbol">政治面貌</param>
        /// <param name="OriginPro">籍贯-省</param>
        /// <param name="HomePro">住址-省</param>
        /// <param name="SchoolType">在校状态（类型）</param>
        /// <param name="Grade">年级</param>
        /// <param name="College">学院</param>
        /// <param name="Profession">专业</param>
        /// <param name="Classes">班级</param>
        /// <returns></returns>
        public DataTable Find_AllStuBySomethings(string StuNo, string Sex, string Nation, string Symbol, string OriginPro,
            string HomePro, string SchoolType, string Grade, string College, string Profession, string Classes)
        {
            StringBuilder Power = new StringBuilder();
            Power = PowerInFind(Power);
            if (StuNo == "") StuNo = "_";
            if (Sex == "") Sex = "_";
            if (Nation == "") Nation = "_";
            if (Symbol == "") Symbol = "_";
            if (OriginPro == "") OriginPro = "_";
            if (HomePro == "") HomePro = "_";
            if (SchoolType == "") SchoolType = "_";
            if (Grade == "") Grade = "_";
            if (College == "") College = "_";
            if (Profession == "") Profession = "_";
            if (Classes == "") Classes = "_";
            StuNo = "%" + StuNo + "%";
            Sex = "%" + Sex + "%";
            Nation = "%" + Nation + "%";
            Symbol = "%" + Symbol + "%";
            OriginPro = "%" + OriginPro + "%";
            HomePro = "%" + HomePro + "%";
            SchoolType = "%" + SchoolType + "%";
            Grade = "%" + Grade + "%";
            College = "%" + College + "%";
            Profession = "%" + Profession + "%";
            Classes = "%" + Classes + "%";
            return stuBaseInfoDAL.Find_AllStuBySomethings(Power, StuNo, Sex, Nation, Symbol, OriginPro, HomePro, SchoolType, Grade, College, Profession, Classes);
        }
    }
}
