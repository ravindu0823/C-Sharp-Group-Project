﻿using System;
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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            payment paynow = new payment();
            paynow.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int x = 120;
            int z = 2;
            int tot1 = x * z;


        }
    }
}
