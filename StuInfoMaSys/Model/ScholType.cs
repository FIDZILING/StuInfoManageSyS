using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 奖学金类型
    /// </summary>
    public class ScholType
    {
        private string type;
        /// <summary>
        /// 奖学金代码
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string scholarstring;
        /// <summary>
        /// 奖学金字符串
        /// </summary>
        public string ScholarString
        {
            get { return scholarstring; }
            set { scholarstring = value; }
        }
    }
}
