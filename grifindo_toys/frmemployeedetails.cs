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
    public partial class frmemployeedetails : Form
    {
        public frmemployeedetails()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Grifindo_Toys;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        SqlCommand com;

        string Gender;
        string sql;

        public void reset()
        {
            txtempid.Clear();
            txtfirstname.Clear();
            txtmiddlename.Clear();
            txtlastname.Clear();
            lbmale.Checked = false;
            lbfemale.Checked = false;
            txtdate.Text = "";
            txtaddress.Clear();
            txtcity.Clear();
            txtsal.Clear();
            txtotrate.Clear();
            txtallow.Clear();
        }



        private void frmemployeedetails_Load(object sender, EventArgs e)
        {

        }



        private void txtempid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT MAX(EmployeeID) FROM tbl_Employee";
                com = new SqlCommand(sql, con);
                con.Open();
                var maxid = com.ExecuteScalar() as string;

                if (maxid == null)
                {
                    txtempid.Text = "A-000001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 6));
                    intval++;
                    txtempid.Text = string.Format("A-{0:000000}", intval);

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
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string sql = "INSERT INTO tbl_Employee (EmployeeID, FirstName, MiddleName, LastName, Gender, Birth_Of_Date, Address, City, MonthlySalary ,OvertimeRate , Allowances ) VALUES ('" + txtempid.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + txtlastname.Text + "','" + Gender + "','" + txtdate.Text + "','" + txtaddress.Text + "','" + txtcity.Text + "','" + txtsal.Text + "','" + txtotrate.Text + "','" + txtallow.Text + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully Added New Employee ", "Save Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lbmale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void lbfemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                btnsave.Enabled = false;
                con.Open();
                string sql = "SELECT * FROM tbl_Employee WHERE EmployeeID = '" + txtsearch.Text + "'";
                com = new SqlCommand(sql, con);

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtempid.Text = dr["EmployeeID"].ToString();
                    txtfirstname.Text = dr["FirstName"].ToString();
                    txtmiddlename.Text = dr["MiddleName"].ToString();
                    txtlastname.Text = dr["LastName"].ToString();
                    string resGrndre = dr["Gender"].ToString();
                    if (resGrndre == "Male")
                    {
                        lbmale.Checked = true;
                    }
                    else if (resGrndre == "Female")
                    {
                        lbfemale.Checked = false;
                    }

                    txtdate.Text = dr["Birth_Of_Date"].ToString();
                    txtaddress.Text = dr["Address"].ToString();
                    txtcity.Text = dr["City"].ToString();
                    txtsal.Text = dr["MonthlySalary"].ToString();
                    txtotrate.Text = dr["OvertimeRate"].ToString();
                    txtallow.Text = dr["Allowances"].ToString();
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
                btnsave.Enabled = true;
                con.Open();
                string sql = "UPDATE tbl_Employee SET EmployeeID = '" + txtempid.Text + "',FirstName = '" + txtfirstname.Text + "',MiddleName = '" + txtmiddlename.Text + "',LastName = '" + txtlastname.Text + "',Gender = '" + Gender + "',Birth_Of_Date = '" + txtdate.Text + "',Address = '" + txtaddress.Text + "',City = '" + txtcity.Text + "',MonthlySalary = '" + txtsal + "',OvertimeRate = '" + txtotrate + "',Allowances = '" + txtallow + "' WHERE EmployeeID = '" + txtempid.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Student Record Updated Successfully", "Updated Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();

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
    
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                btnsave.Enabled = true;
                con.Open();
                string sql = "DELETE FROM tbl_Employee WHERE EmployeeID = '" + txtempid.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Employe Record Deleted Successfully", "Deleted Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Deleted Alert");
            }

            finally
            {
                con.Close();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmadminmenu frmadmin = new frmadminmenu();
            this.Hide();
            frmadmin.Show();

        }   }
    }










    
    
    
    

