using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Appoinment : Form
    {
        public Appoinment()
        {
            InitializeComponent();
        }

        private void Appoinment_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
            string fullname = guna2TextBox1.Text;
            string phonenumber = guna2TextBox2.Text;
            string department = guna2TextBox3.Text;
            string age = guna2TextBox4.Text;
            string appointmentdate = guna2TextBox5.Text;
            string doctor = guna2TextBox6.Text;

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO appointment (Fullname,Phonenumber,Department,Age,Appointment_date,Doctor) VALUES ('" + fullname + "', '" + phonenumber + "', '" + department + "', '" + age + "', '" + appointmentdate + "', '" + doctor + "')";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User insertion sucessfully");
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