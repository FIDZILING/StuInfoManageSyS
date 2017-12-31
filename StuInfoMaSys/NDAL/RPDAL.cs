using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RPDAL
    {
        private static string Sql_Con_Str = DealDAL.Sql_Con_Str;


        /// <summary>
        /// 显示所有奖惩信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_AllRPInfo()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.RewardPunishment");
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
        /// 添加奖惩信息
        /// </summary>
        /// <param name="StuNum">学号</param>
        /// <param name="RPType">奖惩类型</param>
        /// <param name="RPLevel">奖惩等级</param>
        /// <param name="Day">获得时间</param>
        /// <param name="Info">备注信息</param>
        /// <returns></returns>
        public bool Add_RPInfo(string StuNum,string RPType,string RPLevel, DateTime Day,string Info)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("insert into dbo.RewardPunishment (StuNum,RPType,RPLevel,Day,Info) values (@StuNum,@RPType,@RPLevel,@Day,@Info)");
            SqlParameter[] param =
                {
                    new SqlParameter("@StuNum",StuNum),
                    new SqlParameter("@RPType",RPType),
                    new SqlParameter("@RPLevel",RPLevel),
                    new SqlParameter("@Day",Day),
                    new SqlParameter("@Info",Info)
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
        /// 通过学号查询奖惩信息（模糊查询）
        /// </summary>
        /// <param name="StuNum">学号</param>
        /// <returns></returns>
        public DataTable Find_RPInfoByStuNum(string StuNum)
        {
            StringBuilder Sql_Str = new StringBuilder();
            //模糊查询
            StuNum = "%" + StuNum + "%";
            Sql_Str.Append("select *");
            Sql_Str.Append(" from dbo.RewardPunishment");
            Sql_Str.Append(" where StuNum like @StuNum");
            SqlParameter Paras = new SqlParameter("@StuNum", StuNum);
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
        /// 通过奖惩类型查找奖惩信息
        /// </summary>
        /// <param name="RPType">奖惩类型</param>
        /// <returns></returns>
        public DataTable Find_RPInfoByRPType(string RPType)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select *");
            Sql_Str.Append(" from dbo.RewardPunishment");
            Sql_Str.Append(" where RPType=@RPType");
            SqlParameter Paras = new SqlParameter("@RPType", RPType);
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
        /// 通过奖惩等级查询奖惩信息
        /// </summary>
        /// <param name="RPLevel">奖惩等级</param>
        /// <returns></returns>
        public DataTable Find_RPInfoByRPLevel(string RPLevel)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select *");
            Sql_Str.Append(" from dbo.RewardPunishment");
            Sql_Str.Append(" where RPLevel=@RPLevel");
            SqlParameter Paras = new SqlParameter("@RPLevel", RPLevel);
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
    }
}
