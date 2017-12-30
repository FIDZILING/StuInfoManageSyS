using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 领导
    /// </summary>
    public class Leader
    {
        Leader(int id, string name, string passward, string identify, string college, string grade)
        {
            ID = id;
            this.name = name;
            this.passward = passward;
            this.identify = identify;
            this.college = college;
            this.grade = grade;
        }
        private int ID;
        private string name;
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        private string passward;
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return passward; }
            set { passward = value; }
        }
        private string identify;
        /// <summary>
        /// 用户身份
        /// </summary>
        public string Identify
        {
            get { return identify; }
        }
        private string college;
        /// <summary>
        /// 分管学院
        /// </summary>
        public string College
        {
            get { return college; }
        }
        private string grade;
        /// <summary>
        /// 分管年级
        /// </summary>
        public string Grade
        {
            get { return grade; }
        }
    }
}
