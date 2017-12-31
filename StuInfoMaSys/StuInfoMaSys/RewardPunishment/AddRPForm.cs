using BLL;
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

namespace StuInfoMaSys.RewardPunishment
{
    public partial class AddRPForm : Form
    {
        private ClubBLL clubBLL = new ClubBLL();
        private Leader leader;
        public AddRPForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
        }
    }
}
