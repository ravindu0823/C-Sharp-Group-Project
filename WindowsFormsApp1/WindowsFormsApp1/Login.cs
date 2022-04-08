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
    public partial class Form1 : Form
    {
        private NewForm signup = new NewForm();
        private NewForm2 home = new NewForm2();
        private NewForm3 docotorrecords = new NewForm3();
        private Appoinment app = new Appoinment();
        private Lbl_heading bil = new Lbl_heading();
        private PatientHistory ph = new PatientHistory();
        private PatientRecords pr = new PatientRecords();
        private Pharmacy pharmacy = new Pharmacy();
        private Rooms rooms = new Rooms();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            docotorrecords.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ph.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pharmacy.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rooms.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            signup.Show();
        }
    }
}