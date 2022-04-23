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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            ShowRooms();
            ShowPatients();
            ShowRecords();
        }

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

        private void ShowRooms()
        {
            conn_vinuri.Open();

            string get = "SELECT * FROM Rooms WHERE Booked = 'Available'";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_vinuri);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];

            conn_vinuri.Close();
        }

        private void ShowPatients()
        {
            conn_vinuri.Open();

            string get = "SELECT PatientId, CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS 'Full Name', ContactNumber, Gender, DATEDIFF (YY, BirthDate, GETDATE()) AS Age, Address, EmgNumber, BloodGroup FROM PatientRecords";
            // string get = "SELECT DATEDIFF (YY, BirthDate, GETDATE()) AS Age FROM PatientRecords";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_vinuri);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView2.DataSource = ds.Tables[0];

            conn_vinuri.Close();
        }

        private void ShowRecords()
        {
            conn_vinuri.Open();

            string get = "SELECT * FROM RoomManagemenet";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_vinuri);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView3.DataSource = ds.Tables[0];

            conn_vinuri.Close();
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
            if (guna2TextBox21.Text == "" || guna2TextBox11.Text == "")
            {
                MessageBox.Show("Please Fill these Fields");
            }
            else
            {
                int patient_id = int.Parse(guna2TextBox1.Text);
                string full_name = guna2TextBox2.Text;
                int contact = int.Parse(guna2TextBox3.Text);
                string gender = guna2TextBox6.Text;
                int age = int.Parse(guna2TextBox15.Text);
                string address = guna2TextBox5.Text;
                int emg_num = int.Parse(guna2TextBox9.Text);
                string blood_group = guna2TextBox16.Text;
                int room_num = int.Parse(guna2TextBox7.Text);
                string room_type = guna2TextBox4.Text;
                int price = int.Parse(guna2TextBox18.Text);
                int advance = int.Parse(guna2TextBox21.Text);
                int outstanding = price - advance;
                // MessageBox.Show(outstanding.ToString());
                string consultant = guna2TextBox11.Text;
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                try
                {
                    conn_vinuri.Open();

                    string sql1 = "INSERT INTO RoomManagemenet (RoomNum, Id, Name, Contact, Gender, Age, Address, EmgNum, BloodGroup, Advance, Outstanding, Consultant, Date) VALUES ('" + room_num + "', '" + patient_id + "', '" + full_name + "', '" + contact + "', '" + gender + "', '" + age + "', '" + address + "', '" + emg_num + "', '" + blood_group + "', '" + advance + "', '" + outstanding + "', '" + consultant + "', '" + date + "')";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn_vinuri);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Inserted to Room Management table");

                    conn_vinuri.Close();

                    conn_vinuri.Open();

                    string update = "UPDATE Rooms SET Booked = 'Booked' WHERE RoomID = '" + room_num + "'";
                    SqlCommand cmd2 = new SqlCommand(update, conn_vinuri);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Updated Rooms table");

                    conn_vinuri.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    ShowRooms();
                    ShowPatients();
                    ShowRecords();
                }
            }
            
            /*int room_num = int.Parse(guna2TextBox4.Text);
            int id = int.Parse(guna2TextBox1.Text); 
            string name = guna2TextBox2.Text;
            int contact = int.Parse(guna2TextBox3.Text); 
            string gender = guna2ComboBox1.Text;
            string relationship = guna2TextBox14.Text;
            int age = int.Parse(guna2TextBox15.Text); 
            string address = guna2TextBox5.Text;
            int  emgnum = int.Parse(guna2TextBox9.Text); 
            string bloodGroup = guna2TextBox16.Text;
            string RoomType = guna2ComboBox2.Text;
            int Price = int.Parse(guna2TextBox18.Text); 
            int advance = int.Parse(guna2TextBox21.Text); 
            string consultant = guna2TextBox11.Text;
            string date = guna2TextBox13.Text;

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO RoomManagemenet  VALUES ('" + room_num + "', '" + id + "', '" + name + "', '" + contact + "', '" + gender + "', '" + relationship + "', '" + age + "', '" + address + "', '" + emgnum + "', '" + bloodGroup + "','" + RoomType + "','" + Price + "', '" + advance + "', '" + consultant + "', '" + date + "')";

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
            }*/

            
            // MessageBox.Show(date);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox7.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox4.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox18.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox1.Text = guna2DataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox2.Text = guna2DataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox3.Text = guna2DataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox6.Text = guna2DataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            guna2TextBox15.Text = guna2DataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            guna2TextBox5.Text = guna2DataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            guna2TextBox9.Text = guna2DataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            guna2TextBox16.Text = guna2DataGridView2.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}