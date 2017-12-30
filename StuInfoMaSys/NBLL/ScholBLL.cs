using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ScholBLL
    {
        private ScholDAL scholDAL = new ScholDAL();
        /// <summary>
        /// 核对并添加新的奖学金类型
        /// </summary>
        /// <param name="S_Char">奖学金类型</param>
        /// <returns></returns>
        public bool Cherk_ScholType(string S_Char)
        {
            return scholDAL.Cherk_ScholType(S_Char);
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
            return scholDAL.Add_ScholInfo(StdNo, ScholType, ScholLevel, Day);
        }
        /// <summary>
        /// 通过学号查找奖学金信息
        /// </summary>
        /// <param name="StdNo">学号</param>
        /// <returns></returns>
        public DataTable Find_ScholInfoByStdNo(string StdNo)
        {
            return scholDAL.Find_ScholInfoByStdNo(StdNo);
        }
        /// <summary>
        /// 通过奖学金类型查找奖学金信息
        /// </summary>
        /// <param name="ScholType">奖学金类型</param>
        /// <returns></returns>
        public DataTable Find_ScholInfoByScholType(string ScholType)
        {
            return scholDAL.Find_ScholInfoByScholType(ScholType);
        }
        /// <summary>
        /// 显示全部奖学金类型信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_AllType()
        {
            return scholDAL.Find_AllType();
        }
        /// <summary>
        /// 显示全部奖学金信息
        /// </summary>
        /// <returns></returns>
        public DataTable Find_AllInfo()
        {
            return scholDAL.Find_AllInfo();
        }
    }
}
