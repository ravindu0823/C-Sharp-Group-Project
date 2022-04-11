using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        // NewForm2 login = new NewForm2();

        private void NewForm_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            textBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            textBox3.ForeColor = System.Drawing.Color.RoyalBlue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // login.LOGIN.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Name";
                textBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "E-mail")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "E-mail";
                textBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Password";
                textBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            }
        }
    }
}