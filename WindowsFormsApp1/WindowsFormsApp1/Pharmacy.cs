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
            pharmacyOff.Show();
        }

        private void guna2GradientButton1_Click(object sender, System.EventArgs e)
        {
            Medi_Information pharmacist = new Medi_Information();
            pharmacist.Show();
        }

        private void guna2GradientButton2_Click(object sender, System.EventArgs e)
        {
            Prescriptions preescrip = new Prescriptions();
            preescrip.Show();
        }

        private void guna2GradientButton6_Click(object sender, System.EventArgs e)
        {
            surgery SURGERY = new surgery();
            SURGERY.Show();
        }

        private void guna2GradientButton4_Click(object sender, System.EventArgs e)
        {
            payment pay = new payment();
            pay.Show();
        }

        private void guna2GradientButton3_Click(object sender, System.EventArgs e)
        {
            help HELP = new help();
            HELP.Show();
        }
    }
}