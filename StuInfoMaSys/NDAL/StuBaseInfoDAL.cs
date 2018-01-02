using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class StuBaseInfoDAL
    {
        private static string Sql_Con_Str = DealDAL.Sql_Con_Str;

        /// <summary>
        /// 查找本科生所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_ALLStuInformation()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.StudentBaseInformation");
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
        public DataTable Find_FamStuInfo()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.FamilyNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.HomePro,dbo.StudentBaseInformation.HomeCity,dbo.StudentBaseInformation.HomeCounty,dbo.StudentBaseInformation.HomeOther,");
            Sql_Str.Append("dbo.StudentBaseInformation.FaName,dbo.StudentBaseInformation.FaTelNum,dbo.StudentBaseInformation.FaIncome,");
            Sql_Str.Append("dbo.StudentBaseInformation.MaName,dbo.StudentBaseInformation.MaTelNum,dbo.StudentBaseInformation.MaIncome");
            Sql_Str.Append(" from dbo.StudentBaseInformation");
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
        public DataTable Find_PerStuInfo()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.Sex,dbo.StudentBaseInformation.Nation,");
            Sql_Str.Append("dbo.StudentBaseInformation.Birthday,dbo.StudentBaseInformation.Symbol,");
            Sql_Str.Append("dbo.StudentBaseInformation.TelNum,dbo.StudentBaseInformation.QQNum,dbo.StudentBaseInformation.IDNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OriginPro,dbo.StudentBaseInformation.OriginCity,dbo.StudentBaseInformation.OriginCounty,");
            Sql_Str.Append("dbo.StudentBaseInformation.HighSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation");
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
        public DataTable Find_SchStuInfo()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.StudentBaseInformation.StuNo,dbo.StudentBaseInformation.StuName,");
            Sql_Str.Append("dbo.StudentBaseInformation.Sex,dbo.StudentBaseInformation.Nation,");
            Sql_Str.Append("dbo.StudentBaseInformation.Birthday,dbo.StudentBaseInformation.Symbol,");
            Sql_Str.Append("dbo.StudentBaseInformation.TelNum,dbo.StudentBaseInformation.QQNum,dbo.StudentBaseInformation.IDNum,");
            Sql_Str.Append("dbo.StudentBaseInformation.OriginPro,dbo.StudentBaseInformation.OriginCity,dbo.StudentBaseInformation.OriginCounty,");
            Sql_Str.Append("dbo.StudentBaseInformation.HighSchool");
            Sql_Str.Append(" from dbo.StudentBaseInformation");
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
    }
}
