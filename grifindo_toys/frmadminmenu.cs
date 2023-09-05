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
    public partial class frmadminmenu : Form
    {
        public frmadminmenu()
        {
            InitializeComponent();
        }

        private void frmadminmenu_Load(object sender, EventArgs e)
        {

        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            frmemployeedetails frmadminmenu = new frmemployeedetails();
            this.Hide();
            frmadminmenu.Show();
        }

        private void btnsalary_Click(object sender, EventArgs e)
        {
            frmsalary frmadminmenu = new frmsalary();
            this.Hide();
            frmadminmenu.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            frmsettings frmadminmenu = new frmsettings();
            this.Hide();
            frmadminmenu.Show();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            frmview frmadminmenu = new frmview();
            this.Hide();
            frmadminmenu.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            frmlog frmadminmenu = new frmlog();
            this.Hide();
            frmadminmenu.Show();
        }
    }
}
