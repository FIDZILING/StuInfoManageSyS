using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ScholDAL
    {
        private static string Sql_Con_Str = DealDAL.Sql_Con_Str;

        /// <summary>
        /// 查找有无相同的奖学金类型
        /// </summary>
        /// <param name="Type">类型名称</param>
        /// <returns></returns>
        public bool Cherk_ScholType(string S_Char)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.ScholType");
            Sql_Str.Append(" where ScholChar=@ScholChar");
            SqlParameter Param = new SqlParameter("@ScholChar", S_Char);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Param);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);

                if (Data_Table.Rows.Count == 0)
                    return false;
                else
                    return true; // 不为零，存在此奖学金
            }
            catch (Exception ex)
            {
                return true;
            }
            finally
            {
                if (Conn != null)
                    Conn.Dispose();
            }
        }

        /// <summary>
        /// 查找最后一行的数据编号ScholType,返回需要的ScholType
        /// </summary>
        /// <returns></returns>
        public string Find_LastScholType()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select ScholType");
            Sql_Str.Append(" from dbo.ScholType");
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                int k = Data_Table.Rows.Count + 1;
                string CTy;
                //是否超过10
                if (k < 10) CTy = "0" + k.ToString();
                else CTy = k.ToString();
                return CTy;
            }
            catch (Exception ex)
            {
                //读取错误？
                return "null";
            }
            finally
            {
                if (Conn != null)
                    Conn.Dispose();
            }
        }

        /// <summary>
        /// 添加奖学金类型
        /// </summary>
        /// <param name="S_Type">奖学金代码</param>
        /// <param name="S_Char">奖学金类型</param>
        /// <returns></returns>
        public bool Add_ScholType(string S_Type, string S_Char)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("insert into dbo.ScholType (ScholType,ScholChar) values (@ID,@SChar)");
            SqlParameter[] param = {
                new SqlParameter("@ID",S_Type),
                new SqlParameter("@SChar",S_Char)
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
        /// 添加奖学金信息
        /// </summary>
        /// <param name="StdNo">学号</param>
        /// <param name="ScholType">奖学金类型</param>
        /// <param name="ScholLevel">奖学金等级</param>
        /// <param name="Day">奖学金获取时间</param>
        /// <returns></returns>
        public bool Add_ScholInfo(string StdNo, string ScholType, string ScholLevel, DateTime Day)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("insert into dbo.ScholarshipInfo (StdNo,ScholType,ScholLevel,Day) values (@StdNo,@ScholType,@ScholLevel,@Day)");
            SqlParameter[] param =
                {
                    new SqlParameter("@StdNo",StdNo),
                    new SqlParameter("@ScholType",ScholType),
                    new SqlParameter("@ScholLevel",ScholLevel),
                    new SqlParameter("@Day",Day)
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
        /// 通过学号查找奖学金信息（模糊查询）
        /// </summary>
        /// <param name="StdNo">学号</param>
        /// <returns></returns>
        public DataTable Find_ScholInfoByStdNo(string StdNo)
        {
            StringBuilder Sql_Str = new StringBuilder();
            //模糊查询
            StdNo = "%" + StdNo + "%";
            Sql_Str.Append("select dbo.ScholarshipInfo.ID,dbo.ScholarshipInfo.StdNo,");
            Sql_Str.Append("dbo.ScholType.ScholChar,");
            Sql_Str.Append("dbo.ScholarshipInfo.ScholLevel,dbo.ScholarshipInfo.Day");
            Sql_Str.Append(" from dbo.ScholarshipInfo,dbo.ScholType");
            Sql_Str.Append(" where dbo.ScholarshipInfo.ScholType=dbo.ScholType.ScholType and StdNo like @StdNo");
            SqlParameter Paras = new SqlParameter("@StdNo", StdNo);
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
        /// 通过奖学金类型查找奖学金信息
        /// </summary>
        /// <param name="ScholType">奖学金类型</param>
        /// <returns></returns>
        public DataTable Find_ScholInfoByScholType(string ScholType)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.ScholarshipInfo.ID,dbo.ScholarshipInfo.StdNo,");
            Sql_Str.Append("dbo.ScholType.ScholChar,");
            Sql_Str.Append("dbo.ScholarshipInfo.ScholLevel,dbo.ScholarshipInfo.Day");
            Sql_Str.Append(" from dbo.ScholarshipInfo,dbo.ScholType");
            Sql_Str.Append(" where dbo.ScholarshipInfo.ScholType=dbo.ScholType.ScholType and dbo.ScholarshipInfo.ScholType=@ScholType");
            SqlParameter Paras = new SqlParameter("@ScholType", ScholType);
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
        /// 显示全部奖学金类型信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_AllType()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.ScholType");
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
        /// 显示全部奖学金信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_AllInfo()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.ScholarshipInfo.ID,dbo.ScholarshipInfo.StdNo,");
            Sql_Str.Append("dbo.ScholType.ScholChar,");
            Sql_Str.Append("dbo.ScholarshipInfo.ScholLevel,dbo.ScholarshipInfo.Day");
            Sql_Str.Append(" from dbo.ScholarshipInfo,dbo.ScholType");
            Sql_Str.Append(" where dbo.ScholarshipInfo.ScholType=dbo.ScholType.ScholType");
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
