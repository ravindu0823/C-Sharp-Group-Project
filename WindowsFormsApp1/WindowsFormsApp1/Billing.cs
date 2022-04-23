using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

        private void guna2checkoutbtn_Click(object sender, System.EventArgs e)
        {

            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "" || guna2TextBox4.Text == "" || guna2TextBox5.Text == "" || guna2TextBox6.Text == "" || guna2TextBox7.Text == "" || guna2TextBox8.Text == "")
            {
                MessageBox.Show("Fill out all the details");
            }
            else
            {
                string fullname = guna2TextBox1.Text;
                string address1 = guna2TextBox2.Text;
                string address2 = guna2TextBox3.Text;
                string nameoncard = guna2TextBox4.Text;
                long cardnumber = Convert.ToInt64(guna2TextBox5.Text);
                int cvvnumber = Convert.ToInt32(guna2TextBox6.Text);
                int expmonth = Convert.ToInt32(guna2TextBox7.Text);
                int expday = Convert.ToInt32(guna2TextBox8.Text);

                try
                {
                    string qry = "INSERT INTO BillingInfo (CardNumber, FullName, Address1, Address2, NameOnCard, CvvNumber, ExpMonth, ExpDay) VALUES ('" + cardnumber + "', '" + fullname + "', '" + address1 + "', '" + address2 + "', '" + nameoncard + "', '" + cvvnumber + "', '" + expmonth + "', '" + expday + "')";
                    SqlCommand cmd = new SqlCommand(qry, conn_vinuri);

                    conn_vinuri.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");

                    conn_vinuri.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}