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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            guna2TextBox3.PasswordChar = '*';
        }

        
        
        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void button3_Click(object sender, System.EventArgs e)
        {

        }

        private void NewForm2_Load(object sender, System.EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, System.EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, System.EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, System.EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, System.EventArgs e)
        {
            
        }

        private void NewForm2_Load_1(object sender, System.EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, System.EventArgs e)
        {
            Form1 guna1 = new Form1();

            string uname = guna2TextBox2.Text.Trim();
            string password = guna2TextBox3.Text.Trim();

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            try
            {

                string sql = "SELECT * FROM Users WHERE Name = '" + uname + "' AND Password = '" + password + "'";
                // string sql = "SELECT * FROM Users WHERE Name = '" + "dhanu" + "' AND Password = '" + "dhanu1234" + "'";

                SqlDataAdapter sda = new SqlDataAdapter(sql, conn_vinuri);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count > 0)
                {
                    guna1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn_vinuri.Close();
            }




        }

        private void guna2GradientButton2_Click(object sender, System.EventArgs e)
        {
            SignUp signup = new SignUp();

            signup.Show();
        }
    }
}