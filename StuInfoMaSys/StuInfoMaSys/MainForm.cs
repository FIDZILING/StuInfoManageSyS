using Model;
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
    public partial class MainForm : Form
    {
        /// <summary>
        /// 领导者信息
        /// </summary>
        private Leader leader;

        public MainForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = leader.ID + leader.Name + leader.Password + leader.Identify + leader.College + leader.Grade;
        }
    }
}
