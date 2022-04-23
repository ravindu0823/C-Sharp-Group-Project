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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void PAYNOWBTN_Click(object sender, EventArgs e)
        {
            payment paynow = new payment(txtTOTAL.Text);
            paynow.Show();
        }

        private void txtTot_TextChanged(object sender, EventArgs e)
        {
            double a = 120.00;

            double b;
            if (txtTot.Text == "")
            {
                b = 0;
            }
            else
            {
                b = Convert.ToDouble(txtTot.Text);
            }

            double tot = a * b;

            /* lblNaltrexone.Text = "Total Price of Naltrexone" + " " +tot;*/
            lblNaltrexone.Text = tot.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /*double a = 120.00;
            double b = Convert.ToDouble(txtTot.Text);
            double tot = a * b;

            *//* lblNaltrexone.Text = "Total Price of Naltrexone" + " " +tot;*//*
            lblNaltrexone.Text = tot.ToString();*/
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            /*double c = 245.25;
            double d = Convert.ToDouble(txtTot1.Text);
            double tot1 = c * d;

            *//*lblBiotin.Text = "Total Price of Biotin" + " " + tot1;*//*
            lblBiotin.Text = tot1.ToString();*/
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            /*double f = 143.22;
            double g = Convert.ToDouble(txtTot2.Text);
            double tot2 = f * g;

            *//*lblImodium.Text = "Total Price of Imodium A-D" + " " + tot2;*//*
            lblImodium.Text = tot2.ToString();*/
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            /*double h = 441.00;
            double i = Convert.ToDouble(txtTot3.Text);
            double tot3 = h * i;

            *//*lblMisoprostol.Text = "Total Price of Misoprostol" + " " + tot3;*//*
            lblMisoprostol.Text = tot3.ToString();*/
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            /*double l = 112.00;
            double m = Convert.ToDouble(txtTot4.Text);
            double tot4 = l * m;

            *//*lblNurtec.Text = "Total Price of Nurtec ODT" + " " + tot4;*//*
            lblNurtec.Text = tot4.ToString();*/
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            /*double l = 415.12;
            double m = Convert.ToDouble(txtTot5.Text);
            double tot5 = l * m;

            *//*lblGlycopyrrolate.Text = "Total Price of Glycopyrrolate" + " " + tot5;*//*
            lblGlycopyrrolate.Text = tot5.ToString();*/
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            /*double n = 174;
            double p = Convert.ToDouble(txtTot6.Text);
            double tot6 = n * p;

            *//*lblRepaglinide.Text = "Total Price of Repaglinide" + " " + tot6;*//*
            lblRepaglinide.Text = tot6.ToString();*/
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            double q = 720.45;
            double r = Convert.ToDouble(txtTot7.Text);
            double tot7 = q * r;

            /*lblSodiumBicarb.Text = "Total Price of Sodium Bicarbonate" + " " + tot7;*/
            lblSodiumBicarb.Text = tot7.ToString();
        }

        private void btnTOTAL_Click(object sender, EventArgs e)
        {
            double Naltrexone = Convert.ToDouble(lblNaltrexone.Text);
            double Biotin = Convert.ToDouble(lblBiotin.Text);
            double Imodium = Convert.ToDouble(lblImodium.Text);
            double Misoprostol = Convert.ToDouble(lblMisoprostol.Text);
            double Nurtec = Convert.ToDouble(lblNurtec.Text);
            double Glycopyrrolate = Convert.ToDouble(lblGlycopyrrolate.Text);
            double Repaglinide = Convert.ToDouble(lblRepaglinide.Text);
            double SodiumBicarb = Convert.ToDouble(lblSodiumBicarb.Text);

            /* if (Naltrexone != null || Biotin != null || Imodium != null || Misoprostol != null || Nurtec != null || Glycopyrrolate != null || Repaglinide!= null || SodiumBicarb != null)*/
            /*if (lblNaltrexone.Text == null)
            {
                double TOTAL = (Naltrexone + Biotin + Imodium + Misoprostol + Nurtec + Glycopyrrolate + Repaglinide + SodiumBicarb);

                txtTOTAL.Text = TOTAL.ToString();
            }
            else
            {
                MessageBox.Show("Error!!!");
            }*/
            double TOTAL = (Naltrexone + Biotin + Imodium + Misoprostol + Nurtec + Glycopyrrolate + Repaglinide + SodiumBicarb);

            txtTOTAL.Text = TOTAL.ToString();
        }

        private void txtTot1_TextChanged(object sender, EventArgs e)
        {
            double c = 245.25;

            double d;
            if (txtTot1.Text == "")
            {
                d = 0;
            }
            else
            {
                d = Convert.ToDouble(txtTot1.Text);
            }

            double tot1 = c * d;
            /*lblBiotin.Text = "Total Price of Biotin" + " " + tot1;*/
            lblBiotin.Text = tot1.ToString();
        }

        private void txtTot2_TextChanged(object sender, EventArgs e)
        {
            double f = 143.22;
            double g;

            if (txtTot2.Text == "")
            {
                g = 0;
            }
            else
            {
                g = Convert.ToDouble(txtTot2.Text);
            }

            double tot2 = f * g;
            /*lblImodium.Text = "Total Price of Imodium A-D" + " " + tot2;*/
            lblImodium.Text = tot2.ToString();
        }

        private void txtTot3_TextChanged(object sender, EventArgs e)
        {
            double h = 441.00;
            double i;

            if (txtTot3.Text == "")
            {
                i = 0;
            }
            else
            {
                i = Convert.ToDouble(txtTot3.Text);
            }

            double tot3 = h * i;
            /*lblMisoprostol.Text = "Total Price of Misoprostol" + " " + tot3;*/
            lblMisoprostol.Text = tot3.ToString();
        }

        private void txtTot4_TextChanged(object sender, EventArgs e)
        {
            double l = 112.00;
            double m;

            if (txtTot4.Text == "")
            {
                m = 0;
            }
            else
            {
                m = Convert.ToDouble(txtTot4.Text);
            }

            double tot4 = l * m;
            /*lblNurtec.Text = "Total Price of Nurtec ODT" + " " + tot4;*/
            lblNurtec.Text = tot4.ToString();
        }

        private void txtTot5_TextChanged(object sender, EventArgs e)
        {
            double l = 415.12;
            double m;

            if (txtTot5.Text == "")
            {
                m = 0;
            }
            else
            {
                m = Convert.ToDouble(txtTot5.Text);
            }

            double tot5 = l * m;
            /*lblGlycopyrrolate.Text = "Total Price of Glycopyrrolate" + " " + tot5;*/
            lblGlycopyrrolate.Text = tot5.ToString();
        }

        private void txtTot6_TextChanged(object sender, EventArgs e)
        {
            double n = 174;
            double p;

            if (txtTot6.Text == "")
            {
                p = 0;
            }
            else
            {
                p = Convert.ToDouble(txtTot6.Text);
            }

            double tot6 = n * p;
            /*lblRepaglinide.Text = "Total Price of Repaglinide" + " " + tot6;*/
            lblRepaglinide.Text = tot6.ToString();
        }

        private void txtTot7_TextChanged(object sender, EventArgs e)
        {
            double q = 720.45;
            double r;

            if (txtTot7.Text == "")
            {
                r = 0;
            }
            else
            {
                r = Convert.ToDouble(txtTot7.Text);
            }

            double tot7 = q * r;
            /*lblSodiumBicarb.Text = "Total Price of Sodium Bicarbonate" + " " + tot7;*/
            lblSodiumBicarb.Text = tot7.ToString();
        }

        private void Prescriptions_Load(object sender, EventArgs e)
        {
            lblNaltrexone.Text = 0.ToString();
            lblBiotin.Text = 0.ToString();
            lblImodium.Text = 0.ToString();
            lblMisoprostol.Text = 0.ToString();
            lblNurtec.Text = 0.ToString();
            lblGlycopyrrolate.Text = 0.ToString();
            lblRepaglinide.Text = 0.ToString();
            lblSodiumBicarb.Text = 0.ToString();

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
