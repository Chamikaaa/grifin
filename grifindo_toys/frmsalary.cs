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
    public partial class frmsalary : Form
    {
        public frmsalary()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Grifindo_Toys;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        SqlCommand com;

        string sql;

       



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void frmsalary_Load(object sender, EventArgs e)
        {
            btncal.Enabled = false;
            btnsave.Enabled = false;
        }

        // UPDATE

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                btnupdate.Enabled = true;
                btncal.Enabled = true;
                btnsave.Enabled = true;
                con.Open();
                string sql = "SELECT * FROM tbl_Employee WHERE EmployeeID = '" + txtempid.Text + "'";
                com = new SqlCommand(sql, con);

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtmonthsal.Text = dr["MonthlySalary"].ToString();
                    txtotrate.Text = dr["OvertimeRate"].ToString();
                    txtallow.Text = dr["Allowances"].ToString();

                }
                else
                {
                    MessageBox.Show("Employee Record Not Found", "Search Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);

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

            try
            {
                con.Open();
                string abc = "SELECT * FROM tbl_setting";
                com = new SqlCommand(abc, con);

                SqlDataReader aa = com.ExecuteReader();
                if (aa.Read())
                {
                    txtrange.Text = aa["DataRang"].ToString();
                    startdate.Text = aa["SalaryBeginDate"].ToString();
                    enddate.Text = aa["SalaryEndDate"].ToString();
                    txtnoofleaves.Text = aa["NoOfLeaves"].ToString();

                }

                else
                {
                    MessageBox.Show("Employee Record Not Found", "Search Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex + "Search Alert");
            }

            finally
            {
                con.Close();
                btnsave.Enabled = true;
                btncal.Enabled = true;
            }

        }
        //BACK
        private void btnback_Click(object sender, EventArgs e)
        {
            frmadminmenu frmadmin = new frmadminmenu();
            this.Hide();
            frmadmin.Show();
        }

        //CALULATE
        private void btncal_Click(object sender, EventArgs e)
        {
            try
            {
                //No_pay_value

                int salary_cycle_date_range = Convert.ToInt32(txtrange.Text);
                int No_of_absent_days = Convert.ToInt32(txtabsentdays.Text);

                int No_pay_value = (salary_cycle_date_range) * No_of_absent_days;

                txtnopay.Text = No_pay_value.ToString();



                //Base_Pay_value

                int Monthly_Salary = Convert.ToInt32(txtmonthsal.Text);
                int Allowances = Convert.ToInt32(txtallow.Text);
                int Over_time_rate = Convert.ToInt32(txtotrate.Text);
                int no_of_overtime_hours = Convert.ToInt32(txtothours.Text);

                int Base_Pay_value = Monthly_Salary + Allowances + (Over_time_rate * no_of_overtime_hours);

                txtbasepay.Text = Base_Pay_value.ToString();



                //Gross_Pay

                int government_tax_rate = Convert.ToInt32(txttaxrate.Text);

                int Gross_Pay = Base_Pay_value - (No_pay_value + Base_Pay_value * (government_tax_rate / 100));

                txtgrosspay.Text = Base_Pay_value.ToString();

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


        public void ID()
        {
            try
            {
                sql = "SELECT MAX(SalaryRecordID) FROM tbl_SalaryRecord";
                com = new SqlCommand(sql, con);
                con.Open();
                var maxid = com.ExecuteScalar() as string;

                if (string.IsNullOrEmpty(maxid))
                {
                    txtrecord.Text = "R-000001";
                }
                else
                {
                    int startIndex = 2;
                    if (maxid.Length > startIndex)
                    {
                        int intval = int.Parse(maxid.Substring(startIndex));
                        intval++;
                        txtrecord.Text = string.Format("A-{0:000000}", intval);
                    }
                    else
                    {
                        int intval = int.Parse(maxid.Substring(0));
                        intval++;
                        txtrecord.Text = string.Format("A-{0:000000}", intval);
                    }
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

        //SAVE
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_SalaryRecord (SalaryRecordID , EmployeeID , NoofAbsentDays, NoofHolidays, NoofOvertimeHours, NoPayValue, BasePayValue, GrossPay ) VALUES ('" + txtrecord.Text + "','" + txtempid.Text + "','" + txtabsentdays.Text + "','" + txtholidays.Text + "','" + txtothours.Text + "','" + txtnopay.Text + "','" + txtbasepay.Text + "','" + txtgrosspay.Text + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                MessageBox.Show("New Salary Record Added Successfully", "Save Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void startdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

