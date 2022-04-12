using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        // NewForm2 login = new NewForm2();

        private void NewForm_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            textBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            textBox3.ForeColor = System.Drawing.Color.RoyalBlue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // login.LOGIN.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Name";
                textBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "E-mail")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "E-mail";
                textBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Password";
                textBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "Name" || textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name!");
            }

            if (textBox2.Text == "E-mail" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter your E-Mail !");
            }

            if (textBox3.Text == "Password" || textBox3.Text == "")
            {
                MessageBox.Show("Please enter your Password !");
            }*/
            
            if (!checkBox1.Checked)
            {
                MessageBox.Show("You must agree with our Terms and Conditions");
            }

            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

                string name = textBox1.Text;
                string email = textBox2.Text;
                string password = textBox3.Text;

                string sql = "INSERT INTO Users (Name, Email, Password) VALUES ('" + name + "', '" + email + "', '" + password + "')";
                // string sql = "INSERT INTO Users (Name, Email, Password) VALUES ('" + "Ravindu" + "', '" + "guestpc87@gmail.com" + "', '" + "ravindu0823" + "')";

                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added Successfully");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    conn.Close();
                }
            }          
           
        }
    }
}