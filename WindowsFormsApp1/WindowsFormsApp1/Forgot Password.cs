using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                MessageBox.Show("Enter Your Email to get the Password", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string email = guna2TextBox2.Text;

                try
                {
                    SqlCommand get = new SqlCommand("SELECT Password FROM Users WHERE Email = '" + email + "'", conn_ravindu);

                    conn_ravindu.Open();

                    SqlDataReader sdr = get.ExecuteReader();

                    if (sdr.Read())
                    {
                        guna2TextBox1.Text = sdr.GetValue(0).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email Please Try Again", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn_ravindu.Close();
                    guna2TextBox2.Text = "";
                }
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();

            login.Show();
        }
    }
}
