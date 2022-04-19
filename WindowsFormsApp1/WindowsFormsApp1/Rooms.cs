using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void label37_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, System.EventArgs e)
        {

        }

        private void button11_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox22_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox15_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, System.EventArgs e)
        {
            string room_num = guna2TextBox18.Text;
            string id = guna2TextBox1.Text;
            string name = guna2TextBox2.Text;
            string contact = guna2TextBox3.Text;
            string gender = guna2ComboBox1.Text;
            string relationship = guna2TextBox14.Text;
            string age = guna2TextBox15.Text;
            string address = guna2TextBox5.Text;
            string emgnum = guna2TextBox9.Text;
            string bloodGroup = guna2TextBox16.Text;
            string advance = guna2TextBox21.Text;
            string consultant = guna2TextBox11.Text;
            string date = guna2TextBox13.Text;

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO RoomManagemenet  VALUES ('" + room_num + "', '" + id + "', '" + name + "', '" + contact + "', '" + gender + "', '" + relationship + "', '" + age + "', '" + address + "', '" + emgnum + "', '" + bloodGroup + "', '" + advance + "', '" + consultant + "', '" + date + "')";

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