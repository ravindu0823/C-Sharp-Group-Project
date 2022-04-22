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
    public partial class DoctorRecords : Form
    {
        public DoctorRecords()
        {
            InitializeComponent();
            ShowRecords();
        }

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

        private void ShowRecords()
        {
            conn_ravindu.Open();

            string get = "SELECT * FROM DoctorRecord";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_ravindu);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];

            conn_ravindu.Close();
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, System.EventArgs e)
        {
            if (txtDocId.Text == "" || txtDocName.Text == "" || txtProf.Text == "" || txtEmgcyCont.Text == "" || txtPhn.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields");
            }
            else
            {
                int doctor_id = int.Parse(txtDocId.Text);
                string doctor_name = txtDocName.Text;
                string profession = txtProf.Text;
                int emergency_contact = int.Parse(txtEmgcyCont.Text);
                int phone = int.Parse(txtPhn.Text);

                try
                {
                    conn_ravindu.Open();

                    string sql = "INSERT INTO DoctorRecord (doctor_id,doctor_Name,profession,emergency_contact,phone) VALUES ('" + doctor_id + "', '" + doctor_name + "', '" + profession + "', '" + emergency_contact + "', '" + phone + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn_ravindu);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Inserted sucessfully");

                    conn_ravindu.Close();
                    ShowRecords();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (txtDocId.Text == "" || txtDocName.Text == "" || txtProf.Text == "" || txtEmgcyCont.Text == "" || txtPhn.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields");
            }
            else
            {
                int doctor_id = int.Parse(txtDocId.Text);
                string doctor_name = txtDocName.Text;
                string profession = txtProf.Text;
                int emergency_contact = int.Parse(txtEmgcyCont.Text);
                int phone = int.Parse(txtPhn.Text);

                try
                {
                    conn_ravindu.Open();

                    string sql = "UPDATE DoctorRecord SET doctor_name = '" + doctor_name + "', profession = '" + profession + "', emergency_contact = '" + emergency_contact + "', phone = '" + phone + "' WHERE doctor_id = '" + doctor_id + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn_ravindu);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Updated sucessfully");

                    conn_ravindu.Close();
                    ShowRecords();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (txtDocId.Text == "")
            {
                MessageBox.Show("Please Enter the Doctor Id");
            }
            else
            {
                int doctor_id = int.Parse(txtDocId.Text);

                try
                {
                    conn_ravindu.Open();

                    string sql = "DELETE FROM DoctorRecord WHERE doctor_id = '" + doctor_id + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn_ravindu);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Updated sucessfully");

                    conn_ravindu.Close();
                    ShowRecords();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDocId.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDocName.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtProf.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmgcyCont.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtPhn.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}