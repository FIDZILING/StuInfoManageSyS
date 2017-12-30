using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuInfoMaSys
{
    public partial class LoginForm : Form
    {
        private BLL.DealBLL dealBLL = new DealBLL();
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string name = NametextBox.Text.Trim();
            string password = PasswordtextBox.Text.Trim();
            string id = "";
            string identify = "", college = "", grade = "";
            if (name == "" || password == "")
            {
                MessageBox.Show("缺少用户名或密码!");
                return;
            }
            if (dealBLL.Log_In(name, password, out id, out identify, out college, out grade)) // 查询登陆
            {
                StuInfoMaSys.Program.programleader = new Model.Leader(id, name, password, identify, college, grade);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }
    }
}
