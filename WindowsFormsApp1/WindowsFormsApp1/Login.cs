using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewForm2 : Form
    {
        public NewForm2()
        {
            InitializeComponent();
        }

        private NewForm signup = new NewForm();

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            signup.Show();
        }

        private void NewForm2_Load(object sender, System.EventArgs e)
        {

        }
    }
}