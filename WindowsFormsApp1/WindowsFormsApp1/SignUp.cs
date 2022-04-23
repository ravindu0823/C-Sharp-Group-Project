using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void NewForm_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            /*if (guna2TextBox3.Text == "")
            {
                MessageBox.Show("Please enter your name!");
            }
            else if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Please enter your E-mail!");
            }
            else if ()
            {

            }*/

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string name = guna2TextBox3.Text;
            string email = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            string sql = "INSERT INTO Users (Name, Email, Password) VALUES ('" + name + "', '" + email + "', '" + password + "')";
            // string sql = "INSERT INTO Users (Name, Email, Password) VALUES ('" + "Ravindu" + "', '" + "guestpc87@gmail.com" + "', '" + "ravindu0823" + "')";

            SqlCommand cmd = new SqlCommand(sql, conn_vinuri);

            try
            {
                conn_vinuri.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn_vinuri.Close();
            }
        }
    }
}