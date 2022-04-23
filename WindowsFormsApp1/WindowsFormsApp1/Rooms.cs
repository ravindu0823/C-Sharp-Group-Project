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
            conn_ravindu.Open();

            string get = "SELECT * FROM Rooms WHERE Booked = 'Available'";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_ravindu);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];

            conn_ravindu.Close();
        }

        private void ShowPatients()
        {
            conn_ravindu.Open();

            string get = "SELECT PatientId, CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS 'Full Name', ContactNumber, Gender, DATEDIFF (YY, BirthDate, GETDATE()) AS Age, Address, EmgNumber, BloodGroup FROM PatientRecords";
            // string get = "SELECT DATEDIFF (YY, BirthDate, GETDATE()) AS Age FROM PatientRecords";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_ravindu);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView2.DataSource = ds.Tables[0];

            conn_ravindu.Close();
        }

        private void ShowRecords()
        {
            conn_ravindu.Open();

            string get = "SELECT * FROM RoomManagemenet";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_ravindu);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView3.DataSource = ds.Tables[0];

            conn_ravindu.Close();
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
                MessageBox.Show("Please Fill these Fields", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string consultant = guna2TextBox11.Text;
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                try
                {
                    conn_ravindu.Open();

                    string sql1 = "INSERT INTO RoomManagemenet (RoomNum, PatientId, Name, Contact, Gender, Age, Address, EmgNum, BloodGroup, RoomType, Price, Advance, Outstanding, Consultant, Date) VALUES ('" + room_num + "', '" + patient_id + "', '" + full_name + "', '" + contact + "', '" + gender + "', '" + age + "', '" + address + "', '" + emg_num + "', '" + blood_group + "', '" + room_type + "', '" + price + "', '" + advance + "', '" + outstanding + "', '" + consultant + "', '" + date + "')";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn_ravindu);
                    cmd1.ExecuteNonQuery();
                    // MessageBox.Show("Inserted to Room Management table");

                    conn_ravindu.Close();

                    conn_ravindu.Open();

                    string update = "UPDATE Rooms SET Booked = 'Booked' WHERE RoomID = '" + room_num + "'";
                    SqlCommand cmd2 = new SqlCommand(update, conn_ravindu);
                    cmd2.ExecuteNonQuery();
                    // MessageBox.Show("Updated Rooms table");
                    MessageBox.Show("Record Inserted Successfully", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn_ravindu.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    ShowRooms();
                    ShowPatients();
                    ShowRecords();

                    guna2TextBox1.Text = "";
                    guna2TextBox2.Text = "";
                    guna2TextBox3.Text = "";
                    guna2TextBox6.Text = "";
                    guna2TextBox15.Text = "";
                    guna2TextBox5.Text = "";
                    guna2TextBox9.Text = "";
                    guna2TextBox16.Text = "";
                    guna2TextBox7.Text = "";
                    guna2TextBox4.Text = "";
                    guna2TextBox18.Text = "";
                    guna2TextBox21.Text = "";
                    guna2TextBox11.Text = "";
                }
            }
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
            guna2TextBox7.Text = guna2DataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox1.Text = guna2DataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox2.Text = guna2DataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox3.Text = guna2DataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            guna2TextBox6.Text = guna2DataGridView3.SelectedRows[0].Cells[4].Value.ToString();
            guna2TextBox15.Text = guna2DataGridView3.SelectedRows[0].Cells[5].Value.ToString();
            guna2TextBox5.Text = guna2DataGridView3.SelectedRows[0].Cells[6].Value.ToString();
            guna2TextBox9.Text = guna2DataGridView3.SelectedRows[0].Cells[7].Value.ToString();
            guna2TextBox16.Text = guna2DataGridView3.SelectedRows[0].Cells[8].Value.ToString();
            guna2TextBox4.Text = guna2DataGridView3.SelectedRows[0].Cells[9].Value.ToString();
            guna2TextBox18.Text = guna2DataGridView3.SelectedRows[0].Cells[10].Value.ToString();
            guna2TextBox21.Text = guna2DataGridView3.SelectedRows[0].Cells[11].Value.ToString();
            guna2TextBox11.Text = guna2DataGridView3.SelectedRows[0].Cells[13].Value.ToString();
        }

        private void Rooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1_home = new Form1();

            this.Hide();
            form1_home.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox21.Text == "" || guna2TextBox11.Text == "")
            {
                MessageBox.Show("Please Fill the all fields", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int advance = int.Parse(guna2TextBox21.Text);
                string consultant = guna2TextBox11.Text;
                int patient_id = int.Parse(guna2TextBox1.Text);
                int room_num = int.Parse(guna2TextBox7.Text);

                string update = "UPDATE RoomManagemenet SET Advance = '" + advance + "', Consultant = '" + consultant + "' WHERE RoomNum = '" + room_num + "' AND PatientId = '" + patient_id + "'";
                SqlCommand cmd = new SqlCommand(update, conn_ravindu);

                try
                {
                    conn_ravindu.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn_ravindu.Close();

                    ShowRooms();
                    ShowPatients();
                    ShowRecords();

                    guna2TextBox1.Text = "";
                    guna2TextBox2.Text = "";
                    guna2TextBox3.Text = "";
                    guna2TextBox6.Text = "";
                    guna2TextBox15.Text = "";
                    guna2TextBox5.Text = "";
                    guna2TextBox9.Text = "";
                    guna2TextBox16.Text = "";
                    guna2TextBox7.Text = "";
                    guna2TextBox4.Text = "";
                    guna2TextBox18.Text = "";
                    guna2TextBox21.Text = "";
                    guna2TextBox11.Text = "";
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "" || guna2TextBox7.Text == "")
            {
                MessageBox.Show("Please Select a Record", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure to Delete this Record?", "Medicine Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int patient_id = int.Parse(guna2TextBox1.Text);
                    int room_num = int.Parse(guna2TextBox7.Text);

                    try
                    {
                        conn_ravindu.Open();

                        string del = "DELETE FROM RoomManagemenet WHERE RoomNum = '" + room_num + "' AND PatientId = '" + patient_id + "'";
                        SqlCommand cmd1 = new SqlCommand(del, conn_ravindu);
                        cmd1.ExecuteNonQuery();
                        // MessageBox.Show("Deleted From Room Management");

                        conn_ravindu.Close();

                        conn_ravindu.Open();

                        string update1 = "UPDATE Rooms SET Booked = 'Available' WHERE RoomID = '" + room_num + "'";
                        SqlCommand cmd2 = new SqlCommand(update1, conn_ravindu);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Successfully Removed From the Room Management", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        conn_ravindu.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        ShowRooms();
                        ShowPatients();
                        ShowRecords();

                        guna2TextBox1.Text = "";
                        guna2TextBox2.Text = "";
                        guna2TextBox3.Text = "";
                        guna2TextBox6.Text = "";
                        guna2TextBox15.Text = "";
                        guna2TextBox5.Text = "";
                        guna2TextBox9.Text = "";
                        guna2TextBox16.Text = "";
                        guna2TextBox7.Text = "";
                        guna2TextBox4.Text = "";
                        guna2TextBox18.Text = "";
                        guna2TextBox21.Text = "";
                        guna2TextBox11.Text = "";
                    }
                }
            }
        }
    }
}