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

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO Pharmacist (medi_id,name,affect_on,mfg,exp,quantity,box_no,price,supplier_id,supplier_name) VALUES ('" + medi_id + "', '" + name + "', '" + affect_on + "', '" + mfg + "', '" + exp + "', '" + quantity + "', '" + box_no + "', '" + price + "', '" + supplier_id + "', '" + supplier_name + "')";
            //string sql = "INSERT INTO DoctorRecord (doctor_id,doctor_Name,profession,emergency_contact,phone) VALUES ('" + 1001 + "', '" + "Vinuri" + "', '" + "Pol gaama" + "', '" + 1919 + "', '" + 0712246569 + "')";


            SqlCommand cmd = new SqlCommand(sql, conn);

            /*if (textID.Text == "" || textNAME.Text == "" || textAFFON.Text == "" || textMFGDATE.Text == "" || textEXPDATE.Text == "" || textQUANTITY.Text == "" || textBOXNO.Text == "" || textPRICE.Text == "" || textSUPPID.Text == "" || textSUPPNAME.Text == "")
            {
                MessageBox.Show("Fill out all the details");
            }*/
            if ( medi_id == null)
            {
                MessageBox.Show("Fill out all the details");
            }
            else
            {
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

        private void Pharmacist1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Pharmacist' table. You can move, or remove it, as needed.
            this.pharmacistTableAdapter.Fill(this.projectDataSet.Pharmacist);

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
