using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SignUp signup = new SignUp();
        private Login home = new Login();
        private DoctorRecords docotorrecords = new DoctorRecords();
        private Appoinment app = new Appoinment();
        private Billing bil = new Billing();
        private PatientHistory ph = new PatientHistory();
        private Pharmacy pharmacy = new Pharmacy();
        private Rooms rooms = new Rooms();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            app.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            bil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            docotorrecords.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ph.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PatientRecords patient = new PatientRecords();

            this.Hide();
            patient.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            pharmacy.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            rooms.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show("Are you sure to EXIT?", "Vitamind Hospital", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }*/

            /*MessageBox.Show("Vitamind Hospital\n Version 1.0", "Vitamind Hopital", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            Application.Exit();
            // MessageBox.Show("VitaMind Hospital\nVersion 1.0v", "Vitamind Hopital", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}