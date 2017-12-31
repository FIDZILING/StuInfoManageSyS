using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class RPBLL
    {
        private RPDAL rPDAL = new RPDAL();

        /// <summary>
        /// 显示所有奖惩信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_AllRPInfo()
        {
            return rPDAL.Find_AllRPInfo();
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
        public bool Add_RPInfo(string StuNum, string RPType, string RPLevel, DateTime Day, string Info)
        {
            return rPDAL.Add_RPInfo(StuNum, RPType, RPLevel, Day, Info);
        }

        /// <summary>
        /// 通过学号查询奖惩信息（模糊查询）
        /// </summary>
        /// <param name="StuNum">学号</param>
        /// <returns></returns>
        public DataTable Find_RPInfoByStuNum(string StuNum)
        {
            return rPDAL.Find_RPInfoByStuNum(StuNum);
        }

        /// <summary>
        /// 通过奖惩类型查找奖惩信息
        /// </summary>
        /// <param name="RPType">奖惩类型</param>
        /// <returns></returns>
        public DataTable Find_RPInfoByRPType(string RPType)
        {
            return rPDAL.Find_RPInfoByRPType(RPType);
        }

        /// <summary>
        /// 通过奖惩等级查询奖惩信息
        /// </summary>
        /// <param name="RPLevel">奖惩等级</param>
        /// <returns></returns>
        public DataTable Find_RPInfoByRPLevel(string RPLevel)
        {
            return rPDAL.Find_RPInfoByRPLevel(RPLevel);
        }
    }
}
