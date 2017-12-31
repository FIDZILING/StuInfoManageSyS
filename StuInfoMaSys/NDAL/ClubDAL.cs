using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClubDAL
    {
        private static string Sql_Con_Str = DealDAL.Sql_Con_Str;

        /// <summary>
        /// 添加社团信息
        /// </summary>
        /// <param name="ClubName">社团名</param>
        /// <param name="ClubTeach">社团指导老师</param>
        /// <param name="TeacherTel">指导老师手机号</param>
        /// <returns></returns>
        public bool Add_ClubInfo(string ClubName, string ClubTeach, string TeacherTel)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("insert into dbo.ClubInfo (ClubName,ClubTeach,TeacherTel) values (@ClubName,@ClubTeach,@TeacherTel)");
            SqlParameter[] param =
                {
                    new SqlParameter("@ClubName",ClubName),
                    new SqlParameter("@ClubTeach",ClubTeach),
                    new SqlParameter("@TeacherTel",TeacherTel)
                 };
            SqlConnection Conn = null;
            try
            {
                Conn = new SqlConnection(Sql_Con_Str);
                Conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr.ToString(), Conn);
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
                if (Conn != null)
                    Conn.Dispose();
            }
        }

        /// <summary>
        /// 核对是否有重名的社团名，存在返回true
        /// </summary>
        /// <param name="Club_N">社团名</param>
        /// <returns></returns>
        public bool Cherk_ClubName(string Club_N)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.ClubInfo");
            Sql_Str.Append(" where ClubName=@ClubName");
            SqlParameter Param = new SqlParameter("@ClubName", Club_N);
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
                    return true; // 不为零，存在社团名
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
        /// 添加ClubName的社团成员
        /// </summary>
        /// <param name="ClubNum">社团编号</param>
        /// <param name="StuNo">学号</param>
        /// <param name="ClubPost">职位</param>
        /// <returns></returns>
        public bool Add_ClubPeo(string ClubNum, string StuNo, string ClubPost)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("insert into dbo.ClubPeople (ClubNum,StuNo,ClubPost) values (@ClubNum,@StuNo,@ClubPost)");
            SqlParameter[] param =
                {
                    new SqlParameter("@ClubNum",ClubNum),
                    new SqlParameter("@StuNo",StuNo),
                    new SqlParameter("@ClubPost",ClubPost)
                 };
            SqlConnection Conn = null;
            try
            {
                Conn = new SqlConnection(Sql_Con_Str);
                Conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr.ToString(), Conn);
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
                if (Conn != null)
                    Conn.Dispose();
            }
        }

        /// <summary>
        /// 核对社团中是否有该人
        /// </summary>
        /// <param name="ClubNum">社团编号</param>
        /// <param name="StuNo">学号</param>
        /// <returns></returns>
        public bool Cherk_ClubPeo(string ClubNum, string StuNo)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.ClubPeople");
            Sql_Str.Append(" where ClubNum=@ClubNum and StuNo=@StuNo");
            SqlParameter[] Paras = {
                new SqlParameter("@ClubNum", ClubNum),
                new SqlParameter("@StuNo", StuNo)
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

                if (Data_Table.Rows.Count == 0)
                    return false;
                else
                    return true; // 不为零，该社团存在相同的学号的人
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
        /// 查询社团信息总表,返回DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable Find_ALLInfo()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select * from dbo.ClubInfo");
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
        /// 查询社团成员总表,返回DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable Find_ALLPeo()
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("select dbo.ClubPeople.ID,");
            Sql_Str.Append("dbo.ClubInfo.ClubName,");
            Sql_Str.Append("dbo.ClubPeople.StuNo,dbo.ClubPeople.ClubPost");
            Sql_Str.Append(" from dbo.ClubPeople,dbo.ClubInfo");
            Sql_Str.Append(" where dbo.ClubPeople.ClubNum=dbo.ClubInfo.ClubNum");
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
        /// 通过社团名称查询社团信息（模糊查询）
        /// </summary>
        /// <param name="ClubName">社团名</param>
        /// <returns></returns>
        public DataTable Find_ClubInfoByClubName(string ClubName)
        {
            StringBuilder Sql_Str = new StringBuilder();
            //模糊查询
            ClubName = "%" + ClubName + "%";
            Sql_Str.Append("select * from dbo.ClubInfo");
            Sql_Str.Append(" where ClubName like @ClubName");
            SqlParameter Param = new SqlParameter("@ClubName", ClubName);
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
        /// 通过社团名称查询社团成员的信息（模糊查询）
        /// </summary>
        /// <param name="ClubName">社团名称</param>
        /// <returns></returns>
        public DataTable Find_ClubPeoByClubName(string ClubName)
        {
            StringBuilder Sql_Str = new StringBuilder();
            //模糊查询
            ClubName = "%" + ClubName + "%";
            Sql_Str.Append("select dbo.ClubPeople.ID,");
            Sql_Str.Append("dbo.ClubInfo.ClubName,");
            Sql_Str.Append("dbo.ClubPeople.StuNo,dbo.ClubPeople.ClubPost");
            Sql_Str.Append(" from dbo.ClubPeople,dbo.ClubInfo");
            Sql_Str.Append(" where dbo.ClubPeople.ClubNum=dbo.ClubInfo.ClubNum and ClubPeople.ClubNum in");
            Sql_Str.Append(" (select ClubNum from dbo.ClubInfo");
            Sql_Str.Append(" where ClubName like @ClubName)");
            SqlParameter Param = new SqlParameter("@ClubName", ClubName);
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
        /// 通过学号查询社团成员信息（模糊查询）
        /// </summary>
        /// <param name="StuNo">学号</param>
        /// <returns></returns>
        public DataTable Find_ClubPeoByStuNo(string StuNo)
        {
            StringBuilder Sql_Str = new StringBuilder();
            //模糊查询
            StuNo = "%" + StuNo + "%";
            Sql_Str.Append("select dbo.ClubPeople.ID,");
            Sql_Str.Append("dbo.ClubInfo.ClubName,");
            Sql_Str.Append("dbo.ClubPeople.StuNo,dbo.ClubPeople.ClubPost");
            Sql_Str.Append(" from dbo.ClubPeople,dbo.ClubInfo");
            Sql_Str.Append(" where dbo.ClubPeople.ClubNum=dbo.ClubInfo.ClubNum and StuNo like @StuNo");
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
        /// 通过社团编号修改社团信息表的指导老师及其电话
        /// </summary>
        /// <param name="ClubNum">社团编号</param>
        /// <param name="ClubTeach">社团指导老师</param>
        /// <param name="TeacherTel">指导老师电话</param>
        /// <returns></returns>
        public bool Change_ClubInfoByClubNum(string ClubNum, string ClubTeach, string TeacherTel)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("update dbo.ClubInfo");
            Sql_Str.Append(" set ClubTeach=@ClubTeach,TeacherTel=@TeacherTel");
            Sql_Str.Append(" where ClubNum=@ClubNum");
            SqlParameter[] Paras = {
                new SqlParameter("@ClubTeach", ClubTeach),
                new SqlParameter("@TeacherTel", TeacherTel),
                new SqlParameter("@ClubNum", ClubNum)
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
        /// 通过ID修改社团成员信息表中的社团职务
        /// </summary>
        /// <param name="ID">编号</param>
        /// <param name="ClubPost">社团职务</param>
        /// <returns></returns>
        public bool Change_ClubPeoByID(string ID, string ClubPost)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("update dbo.ClubPeople");
            Sql_Str.Append(" set ClubPost=@ClubPost");
            Sql_Str.Append(" where ID=@ID");
            SqlParameter[] Paras = {
                new SqlParameter("@ClubPost", ClubPost),
                new SqlParameter("@ID", ID),
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
        /// 通过ID删除该元组的社团信息
        /// </summary>
        /// <param name="ID">编号</param>
        /// <returns></returns>
        public bool DEL_ClubPeoByID(string ID)
        {
            StringBuilder Sql_Str = new StringBuilder();
            Sql_Str.Append("delete from dbo.ClubPeople");
            Sql_Str.Append(" where ID=@ID");
            SqlParameter Param = new SqlParameter("@ID", ID);
            SqlConnection Conn = new SqlConnection(Sql_Con_Str);
            try
            {
                Conn.Open();
                SqlCommand Cmd = new SqlCommand(Sql_Str.ToString(), Conn);
                Cmd.Parameters.Add(Param);
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
    }
}
