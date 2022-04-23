using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class PatientRecords : Form
    {
        public PatientRecords()
        {
            InitializeComponent();
        }

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click_1(object sender, System.EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label25_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, System.EventArgs e)
        {
            if (guna2TextBox9.Text == "" || guna2TextBox8.Text == "" || guna2TextBox7.Text == "" || guna2TextBox14.Text == "" || guna2ComboBox1.Text == "" || guna2TextBox11.Text == "" || guna2TextBox1.Text == "" || guna2ComboBox2.Text == "")
            {
                MessageBox.Show("Please Fill all the Fields", "Patient Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string first_name = guna2TextBox9.Text;
                string middle_name = guna2TextBox8.Text;
                string last_name = guna2TextBox7.Text;
                string birth_date = guna2DateTimePicker1.Text;
                int contact_number = int.Parse(guna2TextBox14.Text);
                string gender = guna2ComboBox1.Text;
                string address = guna2TextBox11.Text;
                int emg_number = int.Parse(guna2TextBox1.Text);
                string blood_group = guna2ComboBox2.Text;

                try
                {
                    conn_ravindu.Open();

                    string sql = "INSERT INTO PatientRecords (FirstName, MiddleName, LastName, BirthDate, ContactNumber, Gender, Address, EmgNumber, BloodGroup) VALUES ('" + first_name + "', '" + middle_name + "', '" + last_name + "', '" + birth_date + "', '" + contact_number + "', '" + gender + "', '" + address + "', '" + emg_number + "', '" + blood_group + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn_ravindu);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added Successfully", "Patient Records", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn_ravindu.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Patient Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    guna2TextBox1.Text = "";
                    guna2TextBox9.Text = "";
                    guna2TextBox8.Text = "";
                    guna2TextBox7.Text = "";
                    guna2TextBox11.Text = "";
                    guna2TextBox14.Text = "";
                    guna2ComboBox1.Text = "";
                    guna2ComboBox2.Text = "";
                }

            }

        }

        private void PatientRecords_Load(object sender, EventArgs e)
        {

        }

        private void PatientRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1_home = new Form1();

            this.Hide();
            form1_home.Show();
        }
    }
}