using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Data.SqlClient;

namespace grifindo_toys
{
    public partial class frmsettings : Form
    {
        public frmsettings()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\grifindo_toys\grifindo_toys\Database1.mdf;Integrated Security=True");
        SqlCommand com;
        string sql;
        public void reset()
        {
            txtrange.Clear();
            datestart.Value = DateTime.Today;
            dateend.Value = DateTime.Today;
            txtleaves.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string sql = "INSERT INTO tbl_setting ( DataRang, SalaryBeginDate, SalaryEndDate, NoOfLeaves ) VALUES ('" + txtrange.Text + "','" + datestart.Text + "','" + dateend.Text + "','" + txtleaves.Text + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                MessageBox.Show("New Setting Details Added Successfully", "Save Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();

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
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();

        }
        private void btnback_Click(object sender, EventArgs e)
        {
            frmadminmenu frmadmin = new frmadminmenu();
            this.Hide();
            frmadmin.Show();
        }

        private void frmsettings_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_setting ";
                com = new SqlCommand(sql, con);

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtrange.Text = dr["DataRang"].ToString();
                    datestart.Text = dr["SalaryBeginDate"].ToString();
                    dateend.Text = dr["SalaryEndDate"].ToString();
                    txtleaves.Text = dr["NoOfLeaves"].ToString();

                }
                else
                {
                    MessageBox.Show("Student Record Not Found", "Search Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    reset();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex + "Search Alert");
            }

            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "UPDATE tbl_setting SET DataRang = '" + txtrange.Text + "',SalaryBeginDate = '" + datestart.Text + "',SalaryEndDate = '" + dateend.Text + "',NoOfLeaves = '" + txtleaves.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Settings Record Updated Successfully", "Updated Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Updated Alert");
            }

            finally
            {
                con.Close();
            }
        }
    }
}

