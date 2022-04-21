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
            payment paynow = new payment();
            paynow.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            double a = 120;
            double b = Convert.ToDouble(txtTot.Text);
            double tot = a * b;

            lblNaltrexone.Text = "Total Price of Naltrexone" + " " +tot;
        }

       /* private void txtTot1_TextChanged(object sender, EventArgs e)
        {
            double c = 245.25;
            double d = Convert.ToDouble(txtTot1.Text);
            double tot1 = c * d;

            lblBiotin.Text = "Total Price of Biotin" + " " + tot1;
        }*/

       /* private void txtTot2_TextChanged(object sender, EventArgs e)
        {
            double f = 143.22;
            double g = Convert.ToDouble(txtTot2.Text);
            double tot2 = f * g;

            lblImodium.Text = "Total Price of Imodium A-D" + " " + tot2;
        }*/

       /* private void tctTot3_TextChanged(object sender, EventArgs e)
        {
            double h = 441;
            double i = Convert.ToDouble(txtTot3.Text);
            double tot3 = h * i;

            lblMisoprostol.Text = "Total Price of Misoprostol" + " " + tot3;
        }*/

        /*private void txtTot4_TextChanged(object sender, EventArgs e)
        {
            double j = 441;
            double k = Convert.ToDouble(txtTot4.Text);
            double tot4 = j * k;

            lblNurtec.Text = "Total Price of Nurtec ODT" + " " + tot4;
        }*/

       /* private void txtTot5_TextChanged(object sender, EventArgs e)
        {
            double l = 415.12;
            double m = Convert.ToDouble(txtTot5.Text);
            double tot5 = l * m;

            lblGlycopyrrolate.Text = "Total Price of Glycopyrrolate" + " " + tot5;
        }*/

      /*  private void txtTot6_TextChanged(object sender, EventArgs e)
        {
            double n = 174;
            double p = Convert.ToDouble(txtTot6.Text);
            double tot6 = n * p;

            lblRepaglinide.Text = "Total Price of Repaglinide" + " " + tot6;
        }

        private void txtTot7_TextChanged(object sender, EventArgs e)
        {
            double q = 720.45;
            double r = Convert.ToDouble(txtTot7.Text);
            double tot7 = q * r;

            lblSodiumBicarb.Text = "Total Price of Sodium Bicarbonate" + " " + tot7;
        }*/

        private void Prescriptions_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            double c = 245.25;
            double d = Convert.ToDouble(txtTot1.Text);
            double tot1 = c * d;

            lblBiotin.Text = "Total Price of Biotin" + " " + tot1;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            double f = 143.22;
            double g = Convert.ToDouble(txtTot2.Text);
            double tot2 = f * g;

            lblImodium.Text = "Total Price of Imodium A-D" + " " + tot2;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            double h = 441.00;
            double i = Convert.ToDouble(txtTot3.Text);
            double tot3 = h * i;

            lblMisoprostol.Text = "Total Price of Misoprostol" + " " + tot3;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            double l = 112.00;
            double m = Convert.ToDouble(txtTot4.Text);
            double tot4 = l * m;

            lblNurtec.Text = "Total Price of Nurtec ODT" + " " + tot4;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            double l = 415.12;
            double m = Convert.ToDouble(txtTot5.Text);
            double tot5 = l * m;

            lblGlycopyrrolate.Text = "Total Price of Glycopyrrolate" + " " + tot5;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            double n = 174;
            double p = Convert.ToDouble(txtTot6.Text);
            double tot6 = n * p;

            lblRepaglinide.Text = "Total Price of Repaglinide" + " " + tot6;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            double q = 720.45;
            double r = Convert.ToDouble(txtTot7.Text);
            double tot7 = q * r;

            lblSodiumBicarb.Text = "Total Price of Sodium Bicarbonate" + " " + tot7;
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

            double TOTAL = ( Naltrexone + Biotin + Imodium + Misoprostol + Nurtec + Glycopyrrolate + Repaglinide + SodiumBicarb );

            txtTOTAL.Text = TOTAL.ToString();
        }
    }
    /*}
    }
    }
    }*/
}
