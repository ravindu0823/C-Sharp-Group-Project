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
        // public NewForm2 LOGIN = new NewForm2();

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

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_Leave(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void textBox2_Enter(object sender, System.EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox2_Leave(object sender, System.EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void NewForm2_Load_1(object sender, System.EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Blue;
            textBox2.ForeColor = System.Drawing.Color.Blue;
        }
    }
}