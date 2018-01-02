using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StuBaseInfoDAL
    {
        private static string Sql_Con_Str = DealDAL.Sql_Con_Str;
        #region 查找本科生信息

        /// <summary>
        /// 查找本科生所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_ALLStuInformation(StringBuilder Power)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.SchoolType,");
            Sql_Str.Append("dbo.StudentBaseInformation.Grade,dbo.StudentBaseInformation.College,");
            Sql_Str.Append("dbo.StudentBaseInformation.Profession,dbo.StudentBaseInformation.Classes,");
            Sql_Str.Append("dbo.Dormitory.DorArea,dbo.Dormitory.DorBuilding,dbo.Dormitory.DorNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.Sex,dbo.StudentBaseInformation.Nation,");
            Sql_Str.Append("dbo.StudentBaseInformation.Birthday,dbo.StudentBaseInformation.Symbol,");
            Sql_Str.Append("dbo.StudentBaseInformation.TelNum,dbo.StudentBaseInformation.QQNum,dbo.StudentBaseInformation.IDNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OriginPro,dbo.StudentBaseInformation.OriginCity,dbo.StudentBaseInformation.OriginCounty,");
            Sql_Str.Append("dbo.StudentBaseInformation.HighSchool,");
            Sql_Str.Append("dbo.StudentBaseInformation.FamilyNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.HomePro,dbo.StudentBaseInformation.HomeCity,dbo.StudentBaseInformation.HomeCounty,dbo.StudentBaseInformation.HomeOther,");
            Sql_Str.Append("dbo.StudentBaseInformation.FaName,dbo.StudentBaseInformation.FaTelNum,dbo.StudentBaseInformation.FaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.MaName,dbo.StudentBaseInformation.MaTelNum,dbo.StudentBaseInformation.MaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.OutSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation left outer join dbo.Dormitory on (dbo.StudentBaseInformation.DropNum=dbo.Dormitory.ID)");
            Sql_Str.Append(Power);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 查找本科生家庭信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_FamStuInfo(StringBuilder Power)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.FamilyNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.HomePro,dbo.StudentBaseInformation.HomeCity,dbo.StudentBaseInformation.HomeCounty,dbo.StudentBaseInformation.HomeOther,");
            Sql_Str.Append("dbo.StudentBaseInformation.FaName,dbo.StudentBaseInformation.FaTelNum,dbo.StudentBaseInformation.FaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.MaName,dbo.StudentBaseInformation.MaTelNum,dbo.StudentBaseInformation.MaIncome");
            Sql_Str.Append(" from dbo.StudentBaseInformation");
            Sql_Str.Append(Power);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 查找本科生个人信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_PerStuInfo(StringBuilder Power)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.Sex,dbo.StudentBaseInformation.Nation,");
            Sql_Str.Append("dbo.StudentBaseInformation.Birthday,dbo.StudentBaseInformation.Symbol,");
            Sql_Str.Append("dbo.StudentBaseInformation.TelNum,dbo.StudentBaseInformation.QQNum,dbo.StudentBaseInformation.IDNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OriginPro,dbo.StudentBaseInformation.OriginCity,dbo.StudentBaseInformation.OriginCounty,");
            Sql_Str.Append("dbo.StudentBaseInformation.HighSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation");
            Sql_Str.Append(Power);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 查找本科生在校信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_SchStuInfo(StringBuilder Power)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.SchoolType,");
            Sql_Str.Append("dbo.StudentBaseInformation.Grade,dbo.StudentBaseInformation.College,");
            Sql_Str.Append("dbo.StudentBaseInformation.Profession,dbo.StudentBaseInformation.Classes,");
            Sql_Str.Append("dbo.Dormitory.DorArea,dbo.Dormitory.DorBuilding,dbo.Dormitory.DorNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OutSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation left outer join dbo.Dormitory on (dbo.StudentBaseInformation.DropNum=dbo.Dormitory.ID)");
            Sql_Str.Append(Power);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        #endregion

        #region 修改本科生信息

        /// <summary>
        /// 添加本科生基本信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <param name="StuName">姓名</param>
        /// <param name="SchoolType">在校状态</param>
        /// <param name="Sex">性别</param>
        /// <returns></returns>
        public bool Add_BaseStuInfo(string StuNo, string StuName,string SchoolType,string Sex)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("insert into dbo.StudentBaseInformation (StuNo,StuName,SchoolType,Sex)");
            sqlStr.Append(" values (@StuNo,@StuName,@SchoolType,@Sex)");
            SqlParameter[] param = {
                new SqlParameter("@StuNo",StuNo),
                new SqlParameter("@StuName",StuName),
                new SqlParameter("@SchoolType",SchoolType),
                new SqlParameter("@Sex",Sex)
            };
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(Sql_Con_Str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr.ToString(), conn);
                cmd.Parameters.AddRange(param);
                if ((int)cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (conn != null)
                    conn.Dispose();
            }
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
        public bool Change_FamStuInfo(string StuNo,string FamilyNum,string HomePro,string HomeCity,string HomeCounty,string HomeOther,
            string FaName,string FaTelNum,string FaIncome, string MaName, string MaTelNum, string MaIncome)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("update dbo.StudentBaseInformation");
            Sql_Str.Append(" set FamilyNum=@FamilyNum,HomePro=@HomePro,HomeCity=@HomeCity,HomeOther=@HomeOther,");
            Sql_Str.Append("FaName=@FaName,FaTelNum=@FaTelNum,FaIncome=@FaIncome,MaName=@MaName,MaTelNum=@MaTelNum,MaIncome=@MaIncome");
            Sql_Str.Append(" where StuNo=@StuNo");
            SqlParameter[] Paras = {
                new SqlParameter("@StuNo", StuNo),
                new SqlParameter("@FamilyNum", FamilyNum),
                new SqlParameter("@HomePro", HomePro),
                new SqlParameter("@HomeCity", HomeCity),
                new SqlParameter("@HomeCounty", HomeCounty),
                new SqlParameter("@HomeOther", HomeOther),
                new SqlParameter("@FaName", FaName),
                new SqlParameter("@FaTelNum", FaTelNum),
                new SqlParameter("@FaIncome", FaIncome),
                new SqlParameter("@MaName", MaName),
                new SqlParameter("@MaTelNum", MaTelNum),
                new SqlParameter("@MaIncome", MaIncome)
            };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.AddRange(Paras);
                if ((int)Cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
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
        public bool Change_PerStuInfo(string StuNo,string Nation,DateTime Birthday,string Symbol,string TelNum,
            string QQNum,string IDNum,string OriginPro,string OriginCity,string OriginCounty,string HighSchool)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("update dbo.StudentBaseInformation");
            Sql_Str.Append(" set Nation=@Nation,Birthday=@Birthday,Symboly=@Symbol,TelNum=@TelNum,");
            Sql_Str.Append("QQNum=@QQNum,IDNum=@IDNum,OriginPro=@OriginPro,OriginCity=@OriginCity,OriginCounty=@OriginCounty,HighSchool=@HighSchool");
            Sql_Str.Append(" where StuNo=@StuNo");
            SqlParameter[] Paras = {
                new SqlParameter("@StuNo", StuNo),
                new SqlParameter("@Nation", Nation),
                new SqlParameter("@Birthday", Birthday),
                new SqlParameter("@Symbol", Symbol),
                new SqlParameter("@TelNum", TelNum),
                new SqlParameter("@QQNum", QQNum),
                new SqlParameter("@IDNum", IDNum),
                new SqlParameter("@OriginPro", OriginPro),
                new SqlParameter("@OriginCity", OriginCity),
                new SqlParameter("@OriginCounty", OriginCounty),
                new SqlParameter("@HighSchool", HighSchool)
            };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.AddRange(Paras);
                if ((int)Cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
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
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("update dbo.StudentBaseInformation");
            Sql_Str.Append(" set SchoolType=@SchoolType,Grade=@Grade,College=@College,");
            Sql_Str.Append("Profession=@Profession,Classes=@Classes,DropNum=@DropNum,OutSchool=@OutSchool");
            Sql_Str.Append(" where StuNo=@StuNo");
            SqlParameter[] Paras = {
                new SqlParameter("@StuNo", StuNo),
                new SqlParameter("@SchoolType", SchoolType),
                new SqlParameter("@Grade", Grade),
                new SqlParameter("@College", College),
                new SqlParameter("@Profession", Profession),
                new SqlParameter("@Classes", Classes),
                new SqlParameter("@DropNum", DropNum),
                new SqlParameter("@OutSchool", OutSchool)
            };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.AddRange(Paras);
                if ((int)Cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }
        
        /// <summary>
        /// 查找寝室ID，返回(string)ID
        /// </summary>
        /// <param name="DorArea">寝室区域</param>
        /// <param name="DorBuilding">寝室楼</param>
        /// <param name="DorNum">寝室号码</param>
        public string Find_DorID(string DorArea,string DorBuilding,string DorNum)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.Dormitory.ID from dbo.Dormitory");
            Sql_Str.Append(" where DorArea=@DorArea and DorBuilding=@DorBuilding and DorNum=@DorNum");
            SqlParameter[] Paras = {
                 new SqlParameter("@DorArea", DorArea),
                 new SqlParameter("@DorBuilding", DorBuilding),
                 new SqlParameter("@DorNum", DorNum)
            };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.AddRange(Paras);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }
        
        #endregion

        #region 调用相关

        /// <summary>
        /// 通过省调用到市
        /// </summary>
        /// <param name="Pro">市</param>
        /// <returns></returns>
        public DataTable Back_City(string Pro)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select distinct dbo.ProCityCountry.City");
            Sql_Str.Append(" from dbo.ProCityCountry");
            Sql_Str.Append(" where Pro=@Pro");
            SqlParameter Param = new SqlParameter("@Pro", Pro);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 通过市调用到区/县
        /// </summary>
        /// <param name="City">市</param>
        /// <returns></returns>
        public DataTable Back_Country(string City)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.ProCityCountry.Country");
            Sql_Str.Append(" from dbo.ProCityCountry");
            Sql_Str.Append(" where City=@City");
            SqlParameter Param = new SqlParameter("@City", City);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 查找寝室地区
        /// </summary>
        /// <returns></returns>
        public DataTable Back_DorArea()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.Dormitory.DorArea");
            Sql_Str.Append(" from dbo.Dormitory");
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 通过寝室地区查找寝室楼栋
        /// </summary>
        /// <param name="DorArea">寝室地区</param>
        /// <returns></returns>
        public DataTable Back_DorBuilding(string DorArea)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select distinct dbo.Dormitory.DorBuilding");
            Sql_Str.Append(" from dbo.Dormitory");
            Sql_Str.Append(" where DorArea=@DorArea");
            SqlParameter Param = new SqlParameter("@DorArea", DorArea);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 通过寝室楼栋查找寝室号
        /// </summary>
        /// <param name="DorBuilding">寝室楼栋</param>
        /// <returns></returns>
        public DataTable Back_DorNum(string DorBuilding)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.Dormitory.DorNum");
            Sql_Str.Append(" from dbo.Dormitory");
            Sql_Str.Append(" where DorBuilding=@DorBuilding");
            SqlParameter Param = new SqlParameter("@DorBuilding", DorBuilding);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        #endregion

        #region 查找相关

        /// <summary>
        /// 通过学号查询本科生所有信息
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <returns></returns>
        public DataTable Find_AllByStuNoNOVague(string StuNo)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.SchoolType,");
            Sql_Str.Append("dbo.StudentBaseInformation.Grade,dbo.StudentBaseInformation.College,");
            Sql_Str.Append("dbo.StudentBaseInformation.Profession,dbo.StudentBaseInformation.Classes,");
            Sql_Str.Append("dbo.Dormitory.DorArea,dbo.Dormitory.DorBuilding,dbo.Dormitory.DorNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.Sex,dbo.StudentBaseInformation.Nation,");
            Sql_Str.Append("dbo.StudentBaseInformation.Birthday,dbo.StudentBaseInformation.Symbol,");
            Sql_Str.Append("dbo.StudentBaseInformation.TelNum,dbo.StudentBaseInformation.QQNum,dbo.StudentBaseInformation.IDNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OriginPro,dbo.StudentBaseInformation.OriginCity,dbo.StudentBaseInformation.OriginCounty,");
            Sql_Str.Append("dbo.StudentBaseInformation.HighSchool,");
            Sql_Str.Append("dbo.StudentBaseInformation.FamilyNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.HomePro,dbo.StudentBaseInformation.HomeCity,dbo.StudentBaseInformation.HomeCounty,dbo.StudentBaseInformation.HomeOther,");
            Sql_Str.Append("dbo.StudentBaseInformation.FaName,dbo.StudentBaseInformation.FaTelNum,dbo.StudentBaseInformation.FaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.MaName,dbo.StudentBaseInformation.MaTelNum,dbo.StudentBaseInformation.MaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.OutSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation left outer join dbo.Dormitory on (dbo.StudentBaseInformation.DropNum=dbo.Dormitory.ID)");
            Sql_Str.Append(" where StuNo=@StuNo");
            SqlParameter Paras = new SqlParameter("@StuNo", StuNo);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Paras);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 通过学号、性别、民族、政治面貌、籍贯-省查找本科生个人信息（模糊查询）
        /// </summary>
        /// <param name="Power">权利</param>
        /// <param name="StuNo">学号</param>
        /// <param name="Sex">性别</param>
        /// <param name="Nation">民族</param>
        /// <param name="Symbol">政治面貌</param>
        /// <param name="OriginPro">籍贯-省</param>
        /// <returns></returns>
        public DataTable Find_PerStuBySomethings(StringBuilder Power, string StuNo, string Sex, string Nation, string Symbol, string OriginPro)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.Sex,dbo.StudentBaseInformation.Nation,");
            Sql_Str.Append("dbo.StudentBaseInformation.Birthday,dbo.StudentBaseInformation.Symbol,");
            Sql_Str.Append("dbo.StudentBaseInformation.TelNum,dbo.StudentBaseInformation.QQNum,dbo.StudentBaseInformation.IDNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OriginPro,dbo.StudentBaseInformation.OriginCity,dbo.StudentBaseInformation.OriginCounty,");
            Sql_Str.Append("dbo.StudentBaseInformation.HighSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation");
            Sql_Str.Append(Power);
            Sql_Str.Append(" and StuNo like @StuNo and Sex like @Sex");
            Sql_Str.Append(" and Nation like @Nation and Symbol like @Symbol");
            Sql_Str.Append(" and OriginPro like @OriginPro");
            SqlParameter[] Param = {
                new SqlParameter("@StuNo",StuNo),
                new SqlParameter("@Sex",Sex),
                new SqlParameter("@Nation",Nation),
                new SqlParameter("@Symbol",Symbol),
                new SqlParameter("@OriginPro",OriginPro)
            };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.AddRange(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 通过学号、住址-省查询本科生家庭信息
        /// </summary>
        /// <param name="Power">权利</param>
        /// <param name="StuNo">学号</param>
        /// <param name="HomePro">住址-省</param>
        /// <returns></returns>
        public DataTable Find_FamStuBySomethings(StringBuilder Power, string StuNo, string HomePro)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.FamilyNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.HomePro,dbo.StudentBaseInformation.HomeCity,dbo.StudentBaseInformation.HomeCounty,dbo.StudentBaseInformation.HomeOther,");
            Sql_Str.Append("dbo.StudentBaseInformation.FaName,dbo.StudentBaseInformation.FaTelNum,dbo.StudentBaseInformation.FaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.MaName,dbo.StudentBaseInformation.MaTelNum,dbo.StudentBaseInformation.MaIncome");
            Sql_Str.Append(" from dbo.StudentBaseInformation");
            Sql_Str.Append(Power);
            Sql_Str.Append(" and StuNo like @StuNo and HomePro like @HomePro");
            SqlParameter[] Param = {
                new SqlParameter("@StuNo",StuNo),
                new SqlParameter("@HomePro",HomePro),
            };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.AddRange(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
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
        public DataTable Find_SchStuBySomethings(StringBuilder Power, string StuNo, string SchoolType, string Grade, string College, string Profession, string Classes)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.SchoolType,");
            Sql_Str.Append("dbo.StudentBaseInformation.Grade,dbo.StudentBaseInformation.College,");
            Sql_Str.Append("dbo.StudentBaseInformation.Profession,dbo.StudentBaseInformation.Classes,");
            Sql_Str.Append("dbo.Dormitory.DorArea,dbo.Dormitory.DorBuilding,dbo.Dormitory.DorNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OutSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation left outer join dbo.Dormitory on (dbo.StudentBaseInformation.DropNum=dbo.Dormitory.ID)");
            Sql_Str.Append(Power);
            Sql_Str.Append(" and StuNo like @StuNo and SchoolType like @SchoolType");
            Sql_Str.Append(" and Grade like @Grade and College like @College");
            Sql_Str.Append(" and Profession like @Profession and Classes like @Classes");
            SqlParameter[] Param = {
                new SqlParameter("@StuNo",StuNo),
                new SqlParameter("@SchoolType",SchoolType),
                new SqlParameter("@Grade",Grade),
                new SqlParameter("@College",College),
                new SqlParameter("@Profession",Profession),
                new SqlParameter("@Classes",Classes)
            };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 通过超级多的信息来查找本科生所有信息
        /// </summary>
        /// <param name="Demand">权利</param>
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
        public DataTable Find_AllStuBySomethings(StringBuilder Power, string StuNo, string Sex, string Nation, string Symbol, string OriginPro,
            string HomePro, string SchoolType, string Grade, string College, string Profession, string Classes)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.SchoolType,");
            Sql_Str.Append("dbo.StudentBaseInformation.Grade,dbo.StudentBaseInformation.College,");
            Sql_Str.Append("dbo.StudentBaseInformation.Profession,dbo.StudentBaseInformation.Classes,");
            Sql_Str.Append("dbo.Dormitory.DorArea,dbo.Dormitory.DorBuilding,dbo.Dormitory.DorNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.Sex,dbo.StudentBaseInformation.Nation,");
            Sql_Str.Append("dbo.StudentBaseInformation.Birthday,dbo.StudentBaseInformation.Symbol,");
            Sql_Str.Append("dbo.StudentBaseInformation.TelNum,dbo.StudentBaseInformation.QQNum,dbo.StudentBaseInformation.IDNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OriginPro,dbo.StudentBaseInformation.OriginCity,dbo.StudentBaseInformation.OriginCounty,");
            Sql_Str.Append("dbo.StudentBaseInformation.HighSchool,");
            Sql_Str.Append("dbo.StudentBaseInformation.FamilyNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.HomePro,dbo.StudentBaseInformation.HomeCity,dbo.StudentBaseInformation.HomeCounty,dbo.StudentBaseInformation.HomeOther,");
            Sql_Str.Append("dbo.StudentBaseInformation.FaName,dbo.StudentBaseInformation.FaTelNum,dbo.StudentBaseInformation.FaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.MaName,dbo.StudentBaseInformation.MaTelNum,dbo.StudentBaseInformation.MaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.OutSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation left outer join dbo.Dormitory on (dbo.StudentBaseInformation.DropNum=dbo.Dormitory.ID)");
            Sql_Str.Append(Power);
            Sql_Str.Append(" and StuNo like @StuNo and Sex like @Sex");
            Sql_Str.Append(" and Nation like @Nation and Symbol like @Symbol");
            Sql_Str.Append(" and OriginPro like @OriginPro and HomePro like @HomePro");
            Sql_Str.Append(" and SchoolType like @SchoolType");
            Sql_Str.Append(" and Grade like @Grade and College like @College");
            Sql_Str.Append(" and Profession like @Profession and Classes like @Classes");
            SqlParameter[] Param = {
                new SqlParameter("@StuNo",StuNo),
                new SqlParameter("@Sex",Sex),
                new SqlParameter("@Nation",Nation),
                new SqlParameter("@Symbol",Symbol),
                new SqlParameter("@OriginPro",OriginPro),
                new SqlParameter("@HomePro",HomePro),
                new SqlParameter("@SchoolType",SchoolType),
                new SqlParameter("@Grade",Grade),
                new SqlParameter("@College",College),
                new SqlParameter("@Profession",Profession),
                new SqlParameter("@Classes",Classes)
            };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                return Data_Table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
        }

        #endregion
    }
}
