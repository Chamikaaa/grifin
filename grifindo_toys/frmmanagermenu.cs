using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grifindo_toys
{
    public partial class frmmanagermenu : Form
    {
        public frmmanagermenu()
        {
            InitializeComponent();
        }

        private void frmmanagermenu_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            frmlog frmmanagermenu = new frmlog();
            this.Hide();
            frmmanagermenu.Show();
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            frmemployeedetails frmmanagermenu = new frmemployeedetails();
            this.Hide();
            frmmanagermenu.Show();
        }

        private void btnsalary_Click(object sender, EventArgs e)
        {
            frmsalary frmmanagermenu = new frmsalary();
            this.Hide();
            frmmanagermenu.Show();
        }
    }
    }

