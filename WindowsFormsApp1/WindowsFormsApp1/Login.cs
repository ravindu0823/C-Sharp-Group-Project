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

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

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

            if (guna2TextBox2.Text == "" || guna2TextBox3.Text == "")
            {
                MessageBox.Show("Please Enter your Username and Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string uname = guna2TextBox2.Text.Trim();
                string password = guna2TextBox3.Text.Trim();

                try
                {

                    string sql = "SELECT * FROM Users WHERE Name = '" + uname + "' AND Password = '" + password + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn_ravindu);

                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    if (dtbl.Rows.Count > 0)
                    {
                        guna1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn_ravindu.Close();
                }
            }

        }

        private void guna2GradientButton2_Click(object sender, System.EventArgs e)
        {
            SignUp signup = new SignUp();

            this.Hide();
            signup.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();

            this.Hide();
            forgotPassword.Show();
        }
    }
}