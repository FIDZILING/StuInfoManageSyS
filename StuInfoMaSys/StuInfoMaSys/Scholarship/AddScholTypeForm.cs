using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace StuInfoMaSys.Scholarship
{
    public partial class AddScholTypeForm : Form
    {
        private Leader leader;
        public AddScholTypeForm(Leader leader)
        {
            this.leader = leader;
            InitializeComponent();
        }
    }
}
