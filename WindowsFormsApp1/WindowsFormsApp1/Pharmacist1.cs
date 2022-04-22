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
    public partial class Pharmacist1 : Form
    {
        public Pharmacist1()
        {
            InitializeComponent();
            ShowMan();
        }

        SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

        private void ShowMan()
        {
            conn_ravindu.Open();

            string get = "SELECT Id AS ID, medi_id AS 'Medi Id', name AS Name, affect_on AS 'Affect On', mfg AS 'MFG Date', exp AS 'EXP Date', quantity AS Quantity, box_no AS 'Box No', price AS Price, supplier_id AS 'Supplier Id', supplier_name AS 'Supplier Name' FROM Pharmacist";

            SqlDataAdapter sda = new SqlDataAdapter(get, conn_ravindu);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];

            conn_ravindu.Close();
        }


        private void savebtn_Click(object sender, EventArgs e)
        {
            if (textID.Text == "" || textNAME.Text == "" || textAFFON.Text == "" || textMFGDATE.Text == "" || textEXPDATE.Text == "" || textQUANTITY.Text == "" || textBOXNO.Text == "" || textPRICE.Text == "" || textSUPPID.Text == "" || textSUPPNAME.Text == "")
            {
                MessageBox.Show("Please Fill the all fields");
            }
            else
            {
                int medi_id = int.Parse(textID.Text);
                string name = textNAME.Text;
                string affect_on = textAFFON.Text;
                string mfg = textMFGDATE.Text;
                string exp = textEXPDATE.Text;
                int quantity = int.Parse(textQUANTITY.Text);
                int box_no = int.Parse(textBOXNO.Text);
                double price = Convert.ToDouble(textPRICE.Text);
                int supplier_id = int.Parse(textSUPPID.Text);
                string supplier_name = textSUPPNAME.Text;

                try
                {
                    conn_ravindu.Open();

                    string sql = "INSERT INTO Pharmacist (medi_id,name, affect_on,mfg, exp,quantity, box_no,price, supplier_id, supplier_name) VALUES ('" + medi_id + "', '" + name + "', '" + affect_on + "', '" + mfg + "', '" + exp + "', '" + quantity + "', '" + box_no + "', '" + price + "', '" + supplier_id + "', '" + supplier_name + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn_ravindu);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User inserted Succesfully");

                    conn_ravindu.Close();
                    ShowMan();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Pharmacist1_Load(object sender, EventArgs e)
        {


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int medi_id = int.Parse(textID.Text);
            string name = textNAME.Text;
            string affect_on = textAFFON.Text;
            string mfg = textMFGDATE.Text;
            string exp = textEXPDATE.Text;
            int quantity = int.Parse(textQUANTITY.Text);
            int box_no = int.Parse(textBOXNO.Text);
            double price = Convert.ToDouble(textPRICE.Text);
            int supplier_id = int.Parse(textSUPPID.Text);
            string supplier_name = textSUPPNAME.Text;

            string update = "UPDATE Pharmacist SET name = '" + name + "', affect_on = '" + affect_on + "', mfg = '" + mfg + "', exp = '" + exp + "', quantity = '" + quantity + "', box_no = '" + box_no + "', price = '" + price + "', supplier_id = '" + supplier_id + "', supplier_name = '" + supplier_name + "' WHERE medi_id = '" + medi_id + "'";

            // string update = "UPDATE Pharmacist SET name = '"+ "Dhanushka" + "', affect_on = '"+ "ggggggg" + "', mfg = '"+ "2001-08-23" + "', exp = '"+ "2001-08-30" + "', quantity = '"+ 5 + "', box_no = '"+ 100 + "', price = '"+ 5000 + "', supplier_id = '"+ 789 + "', supplier_name = '"+ "Vinuri" + "' WHERE medi_id = '"+ 101 +"'";
            SqlCommand cmd = new SqlCommand(update, conn_ravindu);

            try
            {
                conn_ravindu.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn_ravindu.Close();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int medi_id = int.Parse(textID.Text);
            /*string name = textNAME.Text;
            string affect_on = textAFFON.Text;
            string mfg = textMFGDATE.Text;
            string exp = textEXPDATE.Text;
            int quantity = int.Parse(textQUANTITY.Text);
            int box_no = int.Parse(textBOXNO.Text);
            double price = Convert.ToDouble(textPRICE.Text);
            int supplier_id = int.Parse(textSUPPID.Text);
            string supplier_name = textSUPPNAME.Text;*/

            // SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            // SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string del = "DELETE FROM Pharmacist Where medi_id = '" + medi_id + "'";
            //string sql = "INSERT INTO DoctorRecord (doctor_id,doctor_Name,profession,emergency_contact,phone) VALUES ('" + 1001 + "', '" + "Vinuri" + "', '" + "Pol gaama" + "', '" + 1919 + "', '" + 0712246569 + "')";


            SqlCommand cmd = new SqlCommand(del, conn_ravindu);

            /*if (textID.Text == "" || textNAME.Text == "" || textAFFON.Text == "" || textMFGDATE.Text == "" || textEXPDATE.Text == "" || textQUANTITY.Text == "" || textBOXNO.Text == "" || textPRICE.Text == "" || textSUPPID.Text == "" || textSUPPNAME.Text == "")
            {
                MessageBox.Show("Fill out all the details");
            }*/

            /*else
            {*/
            try
            {
                conn_ravindu.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted sucessfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn_ravindu.Close();
            }
            /*}*/
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textNAME.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textAFFON.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textMFGDATE.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textEXPDATE.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textQUANTITY.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBOXNO.Text = guna2DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textPRICE.Text = guna2DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textSUPPID.Text = guna2DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textSUPPNAME.Text = guna2DataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }
    }
}
