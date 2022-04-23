using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, System.EventArgs e)
        {
            Pharmacy_Office pharmacyOff = new Pharmacy_Office();

            // this.Hide();
            pharmacyOff.Show();
        }

        private void guna2GradientButton1_Click(object sender, System.EventArgs e)
        {
            Medi_Information pharmacist = new Medi_Information();

            // this.Hide();
            pharmacist.Show();
        }

        private void guna2GradientButton2_Click(object sender, System.EventArgs e)
        {
            Prescriptions preescrip = new Prescriptions();

            // this.Hide();
            preescrip.Show();
        }

        private void guna2GradientButton6_Click(object sender, System.EventArgs e)
        {
            
        }

        private void guna2GradientButton4_Click(object sender, System.EventArgs e)
        {
            
        }

        private void guna2GradientButton3_Click(object sender, System.EventArgs e)
        {
            help HELP = new help();

            // this.Hide();
            HELP.Show();
        }

        private void Pharmacy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1_home = new Form1();

            // this.Hide();
            form1_home.Show();
        }
    }
}