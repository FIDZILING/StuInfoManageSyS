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
        /// 判断是否为可插入的奖学金类型
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
                //先判断是否有该奖学金类型，没有再添加
                if (Data_Table.Rows.Count == 0)
                    //插入信息
                    return Add_ScholType(S_Char);
                else
                    //返回错误信息，存在该奖学金信息
                    return false;
            }
            catch (Exception ex)
            {
                return false;
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
        /// <param name="S_Char">奖学金类型</param>
        /// <returns></returns>
        public bool Add_ScholType(string S_Char)
        {
            StringBuilder Sql_Str = new StringBuilder();
            //ScholType导入
            string S_Type = Find_LastScholType();
            if (S_Type != "null")
            {
                Sql_Str.Append("insert");
                Sql_Str.Append(" into dbo.ScholType(ScholType,ScholChar)");
                Sql_Str.Append(" values('@ScholType','@ScholChar')");
                SqlParameter[] Paras =
                    {
                    new SqlParameter("@ScholType",S_Type),
                    new SqlParameter("@ScholChar",S_Char)
                };
                SqlConnection Conn = new SqlConnection(Sql_Con_Str);
                try
                {
                    Conn.Open();
                    SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                    Cmd.Parameters.AddRange(Paras);
                    return true;
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
            else
                return false;
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
                {
                    Conn.Dispose();
                }
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
        public bool Add_ScholInfo(string StdNo, string ScholType, string ScholLevel, string Day)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("insert");
            Sql_Str.Append(" into dbo.ScholarshipInfo(StdNo,ScholType,ScholLevel,Day)");
            Sql_Str.Append(" values('@StdNo','@ScholType','@ScholLevel','@Day')");
            SqlParameter[] Paras =
                {
                    new SqlParameter("@StdNo",StdNo),
                    new SqlParameter("@ScholType",ScholType),
                    new SqlParameter("@ScholLevel",ScholLevel),
                    new SqlParameter("@Day",Day)
                };
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.AddRange(Paras);
                return true;
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
        /// 通过学号查找奖学金信息
        /// </summary>
        /// <param name="StdNo">学号</param>
        /// <returns></returns>
        public DataTable Find_ScholInfoByStdNo(string StdNo)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.ScholarshipInfo");
            Sql_Str.Append(" where StdNo=@StdNo");
            SqlParameter Paras = new SqlParameter("@StdNo", StdNo);
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
        /// 通过奖学金类型查找奖学金信息
        /// </summary>
        /// <param name="ScholType">奖学金类型</param>
        /// <returns></returns>
        public DataTable Find_ScholInfoByScholType(string ScholType)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.ScholarshipInfo");
            Sql_Str.Append(" where ScholType=@ScholType");
            SqlParameter Paras = new SqlParameter("@ScholType", ScholType);
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
            Sql_Str.Append("select * from dbo.ScholarshipInfo");
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
