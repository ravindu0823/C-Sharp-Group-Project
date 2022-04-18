using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DoctorRecords : Form
    {
        public DoctorRecords()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, System.EventArgs e)
        {
            int doctor_id = int.Parse(txtDocId.Text);
            string doctor_name = txtDocName.Text;
            string profession = txtProf.Text;
            int emergency_contact = int.Parse(txtEmgcyCont.Text);
            int phone = int.Parse(txtPhn.Text);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO DoctorRecord (doctor_id,doctor_Name,profession,emergency_contact,phone) VALUES ('" +doctor_id + "', '" + doctor_name + "', '" + profession + "', '" + emergency_contact + "', '" + phone + "')";
            //string sql = "INSERT INTO DoctorRecord (doctor_id,doctor_Name,profession,emergency_contact,phone) VALUES ('" + 1001 + "', '" + "Vinuri" + "', '" + "Pol gaama" + "', '" + 1919 + "', '" + 0712246569 + "')";


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