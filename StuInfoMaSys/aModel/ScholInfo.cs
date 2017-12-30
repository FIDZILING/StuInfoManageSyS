using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 奖学金信息
    /// </summary>
    public class ScholInfo
    {
        public ScholInfo(int id, string studentID, string type, string level, DateTime day)
        {
            this.id = id;
            this.studentID = studentID;
            this.type = type;
            this.level = level;
            this.day = day;
        }
        public ScholInfo(string studentID, string type, string level, DateTime day)
        {
            this.studentID = studentID;
            this.type = type;
            this.level = level;
            this.day = day;
        }
        private int id;
        /// <summary>
        /// 奖学金记录代码
        /// </summary>
        public int ID
        {
            get { return id; }
        }
        private string studentID;
        /// <summary>
        /// 获奖学生学号
        /// </summary>
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        private string type;
        /// <summary>
        /// 奖学金类型
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string level;
        /// <summary>
        /// 奖学金等级
        /// </summary>
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        private DateTime day;
        /// <summary>
        /// 获奖日期
        /// </summary>
        public DateTime Day
        {
            get { return day; }
            set { day = value; }
        }
    }
}
