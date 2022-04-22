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
    public partial class PatientHistory : Form
    {
        public PatientHistory()
        {
            InitializeComponent();
            ShowPatients();
        }

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

        private void ShowPatients()
        {
            conn_ravindu.Open();

            string get = "SELECT * FROM PatientRecords";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_ravindu);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];

            conn_ravindu.Close();
        }

        private void PatientHistory_Load(object sender, EventArgs e)
        {
            ShowPatients();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_age_Click(object sender, EventArgs e)
        {

        }

        private void txt_language_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_firstname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_personaldetails_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void txt_pricegroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_notes_Click(object sender, EventArgs e)
        {

        }

        private void txt_form4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox9.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox8.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox7.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            guna2TextBox14.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            guna2TextBox11.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            guna2ComboBox2.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            guna2TextBox2.Text = guna2DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            guna2TextBox3.Text = guna2DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            guna2ComboBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox9.Text == "" || guna2TextBox8.Text == "" || guna2TextBox7.Text == "" || guna2TextBox14.Text == "" || guna2TextBox11.Text == "" || guna2ComboBox2.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "" || guna2ComboBox1.Text == "")
            {
                MessageBox.Show("Please Fill all the Fields");
            }
            else
            {
                int patient_id = int.Parse(guna2TextBox1.Text);
                string first_name = guna2TextBox9.Text;
                string middle_name = guna2TextBox8.Text;
                string last_name = guna2TextBox7.Text;
                string birth_date = guna2TextBox14.Text;
                int contact_number = int.Parse(guna2TextBox11.Text);
                string gender = guna2ComboBox2.Text;
                string address = guna2TextBox2.Text;
                int emg_num = int.Parse(guna2TextBox3.Text);
                string blood_group = guna2ComboBox1.Text;

                string update = "UPDATE PatientRecords SET FirstName = '" + first_name + "', MiddleName = '" + middle_name + "', LastName = '" + last_name + "', BirthDate = '" + birth_date + "', ContactNumber = '" + contact_number + "', Gender = '" + gender + "', Address = '" + address + "', EmgNumber = '" + emg_num + "', BloodGroup = '" + blood_group + "' WHERE PatientId = '" + patient_id + "'";
                SqlCommand cmd = new SqlCommand(update, conn_ravindu);

                try
                {
                    conn_ravindu.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated Successfully");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    conn_ravindu.Close();
                    ShowPatients();
                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            int patient_id = int.Parse(guna2TextBox1.Text);

            string del = "DELETE FROM PatientRecords WHERE PatientId = '" + patient_id + "'";
            SqlCommand cmd = new SqlCommand(del, conn_ravindu);

            try
            {
                conn_ravindu.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Deleted Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn_ravindu.Close();
                ShowPatients();
            }
        }
    }
}