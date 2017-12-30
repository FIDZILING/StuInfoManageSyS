using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DealBLL
    {
        private DealDAL dealDAL = new DealDAL();
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
        public bool Log_In(string User_Name, string User_Pwd, out string id, out string identify, out string college, out string grade)
        {
            return dealDAL.SignIn_User(User_Name, User_Pwd, out id, out identify, out college, out grade);
        }

        public void Power_Judge(DataTable Data_Table)
        {

        }
    }
}
