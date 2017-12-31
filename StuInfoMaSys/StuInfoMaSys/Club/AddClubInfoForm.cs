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

namespace StuInfoMaSys.Club
{
    public partial class AddClubInfoForm : Form
    {
        private ClubBLL clubBLL = new ClubBLL();
        private Leader leader;
        public AddClubInfoForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
        }
    }
}
