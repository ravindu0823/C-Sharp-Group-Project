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
    }
}
