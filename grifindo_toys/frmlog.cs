using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grifindo_toys
{
    public partial class frmlog : Form
    {
        public frmlog()
        {

            InitializeComponent();
        }


        //SqlConnection con = new SqlConnection('Data Source = (localdb)\ProjectModels; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False');
        //SqlCommand com;
        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnlogin_Click(object sender, EventArgs e, SqlConnection con)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_User WHERE UserName = '" + txtusername.Text + "' AND UserPassword = '" + txtpassword.Text + "'";
                new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string userStatus = dt.Rows[0][4].ToString().Trim();
                    if (userStatus == "Active")
                    {
                        string userType = dt.Rows[0][3].ToString().Trim();

                        if (userType == "Admin")
                        {
                            MessageBox.Show("Logged in Successfully as Administrator", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frmadminmenu frmadmin = new frmadminmenu();
                            frmadmin.Show();

                        }
                        else if (userType == "Supervisor")
                        {
                            MessageBox.Show("Logged in Successfully as Supervisor", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frmmanagermenu frmSupervisor = new frmmanagermenu();
                            frmSupervisor.Show();
                        }
                    }
                    else if (userStatus == "Inactive")
                    {
                        MessageBox.Show("Your Account Has Been Disabled", "Account Disabled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtusername.Clear();
                        txtpassword.Clear();
                        txtusername.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("Username Or Password Incorrect ? Try Again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int exitCode = 0;
                Environment.Exit(exitCode);
            }
        }

        private void frmlog_Load(object sender, EventArgs e)
        {

        }
    }
}
