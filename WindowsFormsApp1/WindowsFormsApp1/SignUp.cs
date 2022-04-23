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
            guna2TextBox2.PasswordChar = '*';
        }

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

        private Login login = new Login();

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

            if (guna2TextBox3.Text == "" || guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || !guna2CheckBox1.Checked)
            {
                MessageBox.Show("Please Fill all the Fields", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = guna2TextBox3.Text;
                string email = guna2TextBox1.Text;
                string password = guna2TextBox2.Text;

                string sql = "INSERT INTO Users (Name, Email, Password) VALUES ('" + name + "', '" + email + "', '" + password + "')";
                SqlCommand cmd = new SqlCommand(sql, conn_ravindu);

                try
                {
                    conn_ravindu.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added Successfully Please LOGIN", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Hide();
                    login.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn_ravindu.Close();
                }
            }

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Login login = new Login();

            login.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Login login = new Login();

            this.Hide();
            login.Show();
        }
    }
}