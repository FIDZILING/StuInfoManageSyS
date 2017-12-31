using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ClubBLL
    {
        private ClubDAL clubDAL = new ClubDAL();

        /// <summary>
        /// 核对并添加社团信息
        /// </summary>
        /// <param name="ClubName"></param>
        /// <param name="ClubTeach"></param>
        /// <param name="TeacherTel"></param>
        /// <returns></returns>
        public bool Add_ClubInfo(string ClubName, string ClubTeach, string TeacherTel)
        {
            if (clubDAL.Cherk_ClubName(ClubName))
                return false;//存在该社团名
            return clubDAL.Add_ClubInfo(ClubName, ClubTeach, TeacherTel);
        }

        /// <summary>
        /// 核对并添加社团人员信息
        /// </summary>
        /// <param name="ClubNum">社团编号</param>
        /// <param name="StuNo">学号</param>
        /// <param name="ClubPost">职务</param>
        /// <returns></returns>
        public bool Add_ClubPeo(string ClubNum, string StuNo, string ClubPost)
        {
            if (clubDAL.Cherk_ClubPeo(ClubNum,StuNo))
                return false;//存在该社团名
            return clubDAL.Add_ClubPeo(ClubNum, StuNo, ClubPost);
        }

        /// <summary>
        /// 查询社团信息总表
        /// </summary>
        /// <returns></returns>
        public DataTable Find_ALLInfo()
        {
            return clubDAL.Find_ALLInfo();
        }

        /// <summary>
        /// 查询社团成员信息总表
        /// </summary>
        /// <returns></returns>
        public DataTable Find_ALLPeo()
        {
            return clubDAL.Find_ALLPeo();
        }

        /// <summary>
        /// 通过社团名称查询社团信息
        /// </summary>
        /// <param name="ClubName"></param>
        /// <returns></returns>
        public DataTable Find_ClubInfoByClubName(string ClubName)
        {
            return clubDAL.Find_ClubInfoByClubName(ClubName);
        }

        /// <summary>
        /// 通过社团名称查询社团成员的信息
        /// </summary>
        /// <param name="ClubName"></param>
        /// <returns></returns>
        public DataTable Find_ClubPeoByClubName(string ClubName)
        {
            return clubDAL.Find_ClubPeoByClubName(ClubName);
        }

        /// <summary>
        /// 通过学号查询社团成员信息
        /// </summary>
        /// <param name="StuNo"></param>
        /// <returns></returns>
        public DataTable Find_ClubPeoByStuNo(String StuNo)
        {
            return clubDAL.Find_ClubPeoByStuNo(StuNo);
        }
    }
}
