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
    public partial class Medi_Information : Form
    {
        public Medi_Information()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
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

            SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO Pharmacist (medi_id,name,affect_on,mfg,exp,quantity,box_no,price,supplier_id,supplier_name) VALUES ('" + medi_id + "', '" + name + "', '" + affect_on + "', '" + mfg + "', '" + exp + "', '" + quantity + "', '" + box_no + "', '" + price + "', '" + supplier_id + "', '" + supplier_name + "')";
            //string sql = "INSERT INTO DoctorRecord (doctor_id,doctor_Name,profession,emergency_contact,phone) VALUES ('" + 1001 + "', '" + "Vinuri" + "', '" + "Pol gaama" + "', '" + 1919 + "', '" + 0712246569 + "')";


            SqlCommand cmd = new SqlCommand(sql, conn_vinuri);

            /*if (textID.Text == "" || textNAME.Text == "" || textAFFON.Text == "" || textMFGDATE.Text == "" || textEXPDATE.Text == "" || textQUANTITY.Text == "" || textBOXNO.Text == "" || textPRICE.Text == "" || textSUPPID.Text == "" || textSUPPNAME.Text == "")
            {
                MessageBox.Show("Fill out all the details");
            }*/
            /*if ( medi_id == null)
            {
                MessageBox.Show("Fill out all the details");
            }
            else
            {*/
                try
                {
                    conn_vinuri.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User insertion sucessfully");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    conn_vinuri.Close();
                }
            /*}*/
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

            SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string update = "UPDATE Pharmacist SET name = '" + name + "', affect_on = '" + affect_on + "', mfg = '" + mfg + "', exp = '" + exp + "', quantity = '" + quantity + "', box_no = '" + box_no + "', price = '" + price + "', supplier_id = '" + supplier_id + "', supplier_name = '" + supplier_name + "' WHERE medi_id = '" + medi_id + "'";
            // string update = "UPDATE Pharmacist SET name = '"+ "Dhanushka" + "', affect_on = '"+ "ggggggg" + "', mfg = '"+ "2001-08-23" + "', exp = '"+ "2001-08-30" + "', quantity = '"+ 5 + "', box_no = '"+ 100 + "', price = '"+ 5000 + "', supplier_id = '"+ 789 + "', supplier_name = '"+ "Vinuri" + "' WHERE medi_id = '"+ 101 +"'";
            SqlCommand cmd = new SqlCommand(update, conn_vinuri);

            try
            {
                conn_vinuri.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn_vinuri.Close();
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

            SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Coding\NSBM\Year 01\Semester 02\C#\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string del = "DELETE FROM Pharmacist Where medi_id = '"+medi_id+"'";
            //string sql = "INSERT INTO DoctorRecord (doctor_id,doctor_Name,profession,emergency_contact,phone) VALUES ('" + 1001 + "', '" + "Vinuri" + "', '" + "Pol gaama" + "', '" + 1919 + "', '" + 0712246569 + "')";


            SqlCommand cmd = new SqlCommand(del, conn_vinuri);

            /*if (textID.Text == "" || textNAME.Text == "" || textAFFON.Text == "" || textMFGDATE.Text == "" || textEXPDATE.Text == "" || textQUANTITY.Text == "" || textBOXNO.Text == "" || textPRICE.Text == "" || textSUPPID.Text == "" || textSUPPNAME.Text == "")
            {
                MessageBox.Show("Fill out all the details");
            }*/
            
            /*else
            {*/
                try
                {
                    conn_vinuri.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted sucessfully");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    conn_vinuri.Close();
                }
            /*}*/
        }
    }
}
