using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class DealDAL
    {
        private static string Sql_Con_Str = "server=localhost;database=StuInfoDB;user id=sa;pwd=sa";
        /// <summary>
        /// 判断输入的用户名和密码是否匹配，匹配返回1
        /// </summary>
        /// <param name="User_Name">用户名</param>
        /// <param name="User_Pwd">密码</param>
        /// <returns></returns>
        public int SignIn_User(string User_Name, string User_Pwd)
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
                DataTable Data_Table = new DataTable();
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Data_Table.Load(dr);
                for (int i = 0; i < Data_Table.Columns.Count; i++)
                {
                    //用户表
                    Data_Table.Rows[0][i].ToString();
                    
                }

               
                Cmd.Parameters.AddRange(Paras);
                return (int)Cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return 0;
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
