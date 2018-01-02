using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;

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
        /// 查找本科生所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_ALLStuInformation()
        {
            string Power = "";
            if (leader.Identify == "1")
                Power = "College like %";
            else if (leader.Identify == "2")
                Power = "College=" + leader.College;
            else if (leader.Identify == "3")
                Power = "College=" + leader.College + "Grade=" + leader.Grade;
            return stuBaseInfoDAL.Find_ALLStuInformation(Power);
        }

        /// <summary>
        /// 查找本科生家庭信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_FamStuInfo()
        {
            string Power = "";
            if (leader.Identify == "1")
                Power = "College like %";
            else if (leader.Identify == "2")
                Power = "College=" + leader.College;
            else if (leader.Identify == "3")
                Power = "College=" + leader.College + "Grade=" + leader.Grade;
            return stuBaseInfoDAL.Find_FamStuInfo(Power);
        }

        /// <summary>
        /// 查找本科生个人信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_PerStuInfo()
        {
            string Power = "";
            if (leader.Identify == "1")
                Power = "College like %";
            else if (leader.Identify == "2")
                Power = "College=" + leader.College;
            else if (leader.Identify == "3")
                Power = "College=" + leader.College + "Grade=" + leader.Grade;
            return stuBaseInfoDAL.Find_PerStuInfo(Power);
        }

        /// <summary>
        /// 查找本科生在校信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_SchStuInfo()
        {
            string Power = "";
            if (leader.Identify == "1")
                Power = "College like %";
            else if (leader.Identify == "2")
                Power = "College=" + leader.College;
            else if (leader.Identify == "3")
                Power = "College=" + leader.College + "Grade=" + leader.Grade;
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
            string Nation, string Birthday, string Symbol, string TelNum,string QQNum, string IDNum, string OriginPro, string OriginCity, string OriginCounty, string HighSchool,
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
        public bool Change_PerStuInfo(string StuNo, string Nation, string Birthday, string Symbol, string TelNum,
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
    }
}
