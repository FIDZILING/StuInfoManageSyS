using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class DealDAL
    {
        public static string Sql_Con_Str = "database=StuInfoDB;user id=sa;pwd=sa;";
        /// <summary>
        /// 判断输入的用户名和密码是否匹配，匹配返回true
        /// </summary>
        /// <param name="User_Name">用户名</param>
        /// <param name="User_Pwd">密码</param>
        /// <param name="id">序号</param>
        /// <param name="identify">身份</param>
        /// <param name="college">分管学院</param>
        /// <param name="grade">分管年级</param>
        /// <returns></returns>
        public bool SignIn_User(string User_Name, string User_Pwd, out string id, out string identify, out string college, out string grade)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.Users");
            Sql_Str.Append(" where Name=@Name and Password=@Password");
            SqlParameter[] Paras =
                {
                    new SqlParameter("@Name",User_Name),
                    new SqlParameter("@Password",User_Pwd)
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
                // 组装信息
                id = Data_Table.Rows[0][0].ToString();
                identify = Data_Table.Rows[0][3].ToString();
                college = Data_Table.Rows[0][4].ToString();
                grade = Data_Table.Rows[0][5].ToString();
                return true;
            }
            catch (Exception ex)
            {
                id = "";
                identify = "";
                college = "";
                grade = "";
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
        /// 数据库连接测试，成功返回true
        /// </summary>
        /// <param name="IP">数据库IP，用户输入</param>
        /// <returns></returns>
        public bool Link_DB(string IP)
        {
            Sql_Con_Str = "server=" + IP + ";" + Sql_Con_Str;
            try
            {
                SqlConnection Conn = new SqlConnection(Sql_Con_Str);
                Conn.Open();
                Conn.Dispose();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }

        }




    }
}
