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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
            /*guna2Panel1.BackColor = Color.FromArgb(125, Color.White);*/
        }

        private void payment_Load(object sender, EventArgs e)
        {
            var posi = this.PointToScreen(guna2Panel1.Location);
            posi = pictureBox1.PointToClient(posi);
            guna2Panel1.Parent = pictureBox1;
            guna2Panel1.Location = posi;
            guna2Panel1.BackColor = Color.FromArgb(110, 0, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*guna2Panel1.BackColor = Color.FromArgb(125, Color.White);*/
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int card_number = int.Parse(txtCardNum.Text);
            string expiry_date = txtEXP.Text;
            int cvv = int.Parse(txtCVV.Text);

            SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
            
            string sql = "INSERT INTO Payment (card_name,expiry_date,cvv) VALUES ('" + card_number + "', '" + expiry_date + "', '" + cvv + "')";

            SqlCommand cmd = new SqlCommand(sql, conn_vinuri);

            try
            {
                conn_vinuri.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted sucessfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn_vinuri.Close();
            }
        }
    }
}
