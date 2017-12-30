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
        /// 判断输入的用户名和密码是否匹配，匹配返回1
        /// </summary>
        /// <param name="User_Name">用户名</param>
        /// <param name="User_Pwd">密码</param>
        /// <returns></returns>
        public int Log_In(string User_Name, string User_Pwd)
        {
            return dealDAL.SignIn_User(User_Name, User_Pwd);
        }

        public void Power_Judge(DataTable Data_Table)
        {

        }
    }
}
