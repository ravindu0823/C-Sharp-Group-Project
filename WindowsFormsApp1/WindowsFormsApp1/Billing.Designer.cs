using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.picbox_cardnumber = new System.Windows.Forms.PictureBox();
            this.picbox_num2 = new System.Windows.Forms.PictureBox();
            this.picbox_num1 = new System.Windows.Forms.PictureBox();
            this.txt_cardnumber = new System.Windows.Forms.TextBox();
            this.txt_nameoncard = new System.Windows.Forms.TextBox();
            this.txt_expmonth = new System.Windows.Forms.TextBox();
            this.txt_cvvnumber = new System.Windows.Forms.TextBox();
            this.txt_expday = new System.Windows.Forms.TextBox();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.lbl_expmonth = new System.Windows.Forms.Label();
            this.lbl_expday = new System.Windows.Forms.Label();
            this.lbl_cvvnumber = new System.Windows.Forms.Label();
            this.lbl_cardnumber = new System.Windows.Forms.Label();
            this.lbl_nameoncard = new System.Windows.Forms.Label();
            this.lbl_creditcardinfo = new System.Windows.Forms.Label();
            this.lbl_address1 = new System.Windows.Forms.Label();
            this.lbl_address2 = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_bilingaddress = new System.Windows.Forms.Label();
            this.lbl_paypal = new System.Windows.Forms.Label();
            this.lbl_giftcard = new System.Windows.Forms.Label();
            this.lbl_creditcard = new System.Windows.Forms.Label();
            this.picbox_creditcard = new System.Windows.Forms.PictureBox();
            this.picbox_paypal = new System.Windows.Forms.PictureBox();
            this.picbox_giftcard = new System.Windows.Forms.PictureBox();
            this.picbox_grey2 = new System.Windows.Forms.PictureBox();
            this.picbox_grey3 = new System.Windows.Forms.PictureBox();
            this.picbox_grey1 = new System.Windows.Forms.PictureBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.Lbl_heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cardnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_creditcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_paypal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_giftcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_grey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_grey3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_grey1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_cardnumber
            // 
            this.picbox_cardnumber.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cardnumber.Image")));
            this.picbox_cardnumber.Location = new System.Drawing.Point(986, 545);
            this.picbox_cardnumber.Name = "picbox_cardnumber";
            this.picbox_cardnumber.Size = new System.Drawing.Size(36, 21);
            this.picbox_cardnumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_cardnumber.TabIndex = 65;
            this.picbox_cardnumber.TabStop = false;
            // 
            // picbox_num2
            // 
            this.picbox_num2.Image = ((System.Drawing.Image)(resources.GetObject("picbox_num2.Image")));
            this.picbox_num2.Location = new System.Drawing.Point(636, 345);
            this.picbox_num2.Name = "picbox_num2";
            this.picbox_num2.Size = new System.Drawing.Size(43, 32);
            this.picbox_num2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_num2.TabIndex = 64;
            this.picbox_num2.TabStop = false;
            // 
            // picbox_num1
            // 
            this.picbox_num1.Image = ((System.Drawing.Image)(resources.GetObject("picbox_num1.Image")));
            this.picbox_num1.Location = new System.Drawing.Point(165, 345);
            this.picbox_num1.Name = "picbox_num1";
            this.picbox_num1.Size = new System.Drawing.Size(45, 32);
            this.picbox_num1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_num1.TabIndex = 63;
            this.picbox_num1.TabStop = false;
            // 
            // txt_cardnumber
            // 
            this.txt_cardnumber.Location = new System.Drawing.Point(636, 543);
            this.txt_cardnumber.Name = "txt_cardnumber";
            this.txt_cardnumber.Size = new System.Drawing.Size(392, 22);
            this.txt_cardnumber.TabIndex = 62;
            // 
            // txt_nameoncard
            // 
            this.txt_nameoncard.Location = new System.Drawing.Point(636, 462);
            this.txt_nameoncard.Name = "txt_nameoncard";
            this.txt_nameoncard.Size = new System.Drawing.Size(392, 22);
            this.txt_nameoncard.TabIndex = 61;
            // 
            // txt_expmonth
            // 
            this.txt_expmonth.Location = new System.Drawing.Point(788, 632);
            this.txt_expmonth.Name = "txt_expmonth";
            this.txt_expmonth.Size = new System.Drawing.Size(119, 22);
            this.txt_expmonth.TabIndex = 60;
            // 
            // txt_cvvnumber
            // 
            this.txt_cvvnumber.Location = new System.Drawing.Point(636, 632);
            this.txt_cvvnumber.Name = "txt_cvvnumber";
            this.txt_cvvnumber.Size = new System.Drawing.Size(133, 22);
            this.txt_cvvnumber.TabIndex = 59;
            // 
            // txt_expday
            // 
            this.txt_expday.Location = new System.Drawing.Point(928, 632);
            this.txt_expday.Name = "txt_expday";
            this.txt_expday.Size = new System.Drawing.Size(100, 22);
            this.txt_expday.TabIndex = 58;
            // 
            // txt_address1
            // 
            this.txt_address1.Location = new System.Drawing.Point(164, 543);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(276, 22);
            this.txt_address1.TabIndex = 57;
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(166, 632);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(274, 22);
            this.txt_address2.TabIndex = 56;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(165, 462);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(275, 22);
            this.txt_fullname.TabIndex = 55;
            // 
            // lbl_expmonth
            // 
            this.lbl_expmonth.AutoSize = true;
            this.lbl_expmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expmonth.Location = new System.Drawing.Point(784, 592);
            this.lbl_expmonth.Name = "lbl_expmonth";
            this.lbl_expmonth.Size = new System.Drawing.Size(123, 20);
            this.lbl_expmonth.TabIndex = 54;
            this.lbl_expmonth.Text = "EXP. MONTH";
            // 
            // lbl_expday
            // 
            this.lbl_expday.AutoSize = true;
            this.lbl_expday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expday.Location = new System.Drawing.Point(924, 592);
            this.lbl_expday.Name = "lbl_expday";
            this.lbl_expday.Size = new System.Drawing.Size(93, 20);
            this.lbl_expday.TabIndex = 53;
            this.lbl_expday.Text = "EXP. DAY";
            // 
            // lbl_cvvnumber
            // 
            this.lbl_cvvnumber.AutoSize = true;
            this.lbl_cvvnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cvvnumber.Location = new System.Drawing.Point(632, 592);
            this.lbl_cvvnumber.Name = "lbl_cvvnumber";
            this.lbl_cvvnumber.Size = new System.Drawing.Size(131, 20);
            this.lbl_cvvnumber.TabIndex = 52;
            this.lbl_cvvnumber.Text = "CVV NUMBER";
            // 
            // lbl_cardnumber
            // 
            this.lbl_cardnumber.AutoSize = true;
            this.lbl_cardnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardnumber.Location = new System.Drawing.Point(632, 509);
            this.lbl_cardnumber.Name = "lbl_cardnumber";
            this.lbl_cardnumber.Size = new System.Drawing.Size(146, 20);
            this.lbl_cardnumber.TabIndex = 51;
            this.lbl_cardnumber.Text = "CARD NUMBER";
            // 
            // lbl_nameoncard
            // 
            this.lbl_nameoncard.AutoSize = true;
            this.lbl_nameoncard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameoncard.Location = new System.Drawing.Point(632, 420);
            this.lbl_nameoncard.Name = "lbl_nameoncard";
            this.lbl_nameoncard.Size = new System.Drawing.Size(152, 20);
            this.lbl_nameoncard.TabIndex = 50;
            this.lbl_nameoncard.Text = "NAME ON CARD";
            // 
            // lbl_creditcardinfo
            // 
            this.lbl_creditcardinfo.AutoSize = true;
            this.lbl_creditcardinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creditcardinfo.Location = new System.Drawing.Point(709, 345);
            this.lbl_creditcardinfo.Name = "lbl_creditcardinfo";
            this.lbl_creditcardinfo.Size = new System.Drawing.Size(228, 32);
            this.lbl_creditcardinfo.TabIndex = 49;
            this.lbl_creditcardinfo.Text = "Credit Card Info";
            // 
            // lbl_address1
            // 
            this.lbl_address1.AutoSize = true;
            this.lbl_address1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address1.Location = new System.Drawing.Point(162, 509);
            this.lbl_address1.Name = "lbl_address1";
            this.lbl_address1.Size = new System.Drawing.Size(114, 20);
            this.lbl_address1.TabIndex = 48;
            this.lbl_address1.Text = "ADDRESS 1";
            // 
            // lbl_address2
            // 
            this.lbl_address2.AutoSize = true;
            this.lbl_address2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address2.Location = new System.Drawing.Point(165, 592);
            this.lbl_address2.Name = "lbl_address2";
            this.lbl_address2.Size = new System.Drawing.Size(114, 20);
            this.lbl_address2.TabIndex = 47;
            this.lbl_address2.Text = "ADDRESS 2";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(161, 420);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(113, 20);
            this.lbl_fullname.TabIndex = 46;
            this.lbl_fullname.Text = "FULL NAME";
            // 
            // lbl_bilingaddress
            // 
            this.lbl_bilingaddress.AutoSize = true;
            this.lbl_bilingaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bilingaddress.Location = new System.Drawing.Point(230, 345);
            this.lbl_bilingaddress.Name = "lbl_bilingaddress";
            this.lbl_bilingaddress.Size = new System.Drawing.Size(216, 32);
            this.lbl_bilingaddress.TabIndex = 45;
            this.lbl_bilingaddress.Text = "Billing address";
            // 
            // lbl_paypal
            // 
            this.lbl_paypal.AutoSize = true;
            this.lbl_paypal.BackColor = System.Drawing.Color.LightGray;
            this.lbl_paypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paypal.Location = new System.Drawing.Point(702, 273);
            this.lbl_paypal.Name = "lbl_paypal";
            this.lbl_paypal.Size = new System.Drawing.Size(67, 20);
            this.lbl_paypal.TabIndex = 44;
            this.lbl_paypal.Text = "PayPal";
            // 
            // lbl_giftcard
            // 
            this.lbl_giftcard.AutoSize = true;
            this.lbl_giftcard.BackColor = System.Drawing.Color.LightGray;
            this.lbl_giftcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giftcard.Location = new System.Drawing.Point(506, 273);
            this.lbl_giftcard.Name = "lbl_giftcard";
            this.lbl_giftcard.Size = new System.Drawing.Size(86, 20);
            this.lbl_giftcard.TabIndex = 43;
            this.lbl_giftcard.Text = "Gift Card";
            // 
            // lbl_creditcard
            // 
            this.lbl_creditcard.AutoSize = true;
            this.lbl_creditcard.BackColor = System.Drawing.Color.LightGray;
            this.lbl_creditcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creditcard.Location = new System.Drawing.Point(312, 273);
            this.lbl_creditcard.Name = "lbl_creditcard";
            this.lbl_creditcard.Size = new System.Drawing.Size(106, 20);
            this.lbl_creditcard.TabIndex = 42;
            this.lbl_creditcard.Text = "Credit Card";
            // 
            // picbox_creditcard
            // 
            this.picbox_creditcard.BackColor = System.Drawing.Color.LightGray;
            this.picbox_creditcard.Image = ((System.Drawing.Image)(resources.GetObject("picbox_creditcard.Image")));
            this.picbox_creditcard.Location = new System.Drawing.Point(334, 209);
            this.picbox_creditcard.Name = "picbox_creditcard";
            this.picbox_creditcard.Size = new System.Drawing.Size(74, 57);
            this.picbox_creditcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_creditcard.TabIndex = 41;
            this.picbox_creditcard.TabStop = false;
            // 
            // picbox_paypal
            // 
            this.picbox_paypal.BackColor = System.Drawing.Color.LightGray;
            this.picbox_paypal.Image = ((System.Drawing.Image)(resources.GetObject("picbox_paypal.Image")));
            this.picbox_paypal.Location = new System.Drawing.Point(705, 209);
            this.picbox_paypal.Name = "picbox_paypal";
            this.picbox_paypal.Size = new System.Drawing.Size(68, 57);
            this.picbox_paypal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_paypal.TabIndex = 40;
            this.picbox_paypal.TabStop = false;
            // 
            // picbox_giftcard
            // 
            this.picbox_giftcard.BackColor = System.Drawing.Color.LightGray;
            this.picbox_giftcard.Image = ((System.Drawing.Image)(resources.GetObject("picbox_giftcard.Image")));
            this.picbox_giftcard.Location = new System.Drawing.Point(509, 202);
            this.picbox_giftcard.Name = "picbox_giftcard";
            this.picbox_giftcard.Size = new System.Drawing.Size(93, 75);
            this.picbox_giftcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_giftcard.TabIndex = 39;
            this.picbox_giftcard.TabStop = false;
            // 
            // picbox_grey2
            // 
            this.picbox_grey2.BackColor = System.Drawing.Color.LightGray;
            this.picbox_grey2.Location = new System.Drawing.Point(482, 202);
            this.picbox_grey2.Name = "picbox_grey2";
            this.picbox_grey2.Size = new System.Drawing.Size(143, 102);
            this.picbox_grey2.TabIndex = 38;
            this.picbox_grey2.TabStop = false;
            // 
            // picbox_grey3
            // 
            this.picbox_grey3.BackColor = System.Drawing.Color.LightGray;
            this.picbox_grey3.Location = new System.Drawing.Point(665, 202);
            this.picbox_grey3.Name = "picbox_grey3";
            this.picbox_grey3.Size = new System.Drawing.Size(143, 102);
            this.picbox_grey3.TabIndex = 37;
            this.picbox_grey3.TabStop = false;
            // 
            // picbox_grey1
            // 
            this.picbox_grey1.BackColor = System.Drawing.Color.LightGray;
            this.picbox_grey1.Location = new System.Drawing.Point(297, 202);
            this.picbox_grey1.Name = "picbox_grey1";
            this.picbox_grey1.Size = new System.Drawing.Size(143, 102);
            this.picbox_grey1.TabIndex = 36;
            this.picbox_grey1.TabStop = false;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_description.Location = new System.Drawing.Point(327, 126);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(431, 50);
            this.lbl_description.TabIndex = 35;
            this.lbl_description.Text = "Choose the payment option below and fill out the\r\n                      appropria" +
    "te information";
            // 
            // Lbl_heading
            // 
            this.Lbl_heading.AutoSize = true;
            this.Lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_heading.Location = new System.Drawing.Point(422, 61);
            this.Lbl_heading.Name = "Lbl_heading";
            this.Lbl_heading.Size = new System.Drawing.Size(248, 54);
            this.Lbl_heading.TabIndex = 34;
            this.Lbl_heading.Text = "Billing Info";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 715);
            this.Controls.Add(this.picbox_cardnumber);
            this.Controls.Add(this.picbox_num2);
            this.Controls.Add(this.picbox_num1);
            this.Controls.Add(this.txt_cardnumber);
            this.Controls.Add(this.txt_nameoncard);
            this.Controls.Add(this.txt_expmonth);
            this.Controls.Add(this.txt_cvvnumber);
            this.Controls.Add(this.txt_expday);
            this.Controls.Add(this.txt_address1);
            this.Controls.Add(this.txt_address2);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.lbl_expmonth);
            this.Controls.Add(this.lbl_expday);
            this.Controls.Add(this.lbl_cvvnumber);
            this.Controls.Add(this.lbl_cardnumber);
            this.Controls.Add(this.lbl_nameoncard);
            this.Controls.Add(this.lbl_creditcardinfo);
            this.Controls.Add(this.lbl_address1);
            this.Controls.Add(this.lbl_address2);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.lbl_bilingaddress);
            this.Controls.Add(this.lbl_paypal);
            this.Controls.Add(this.lbl_giftcard);
            this.Controls.Add(this.lbl_creditcard);
            this.Controls.Add(this.picbox_creditcard);
            this.Controls.Add(this.picbox_paypal);
            this.Controls.Add(this.picbox_giftcard);
            this.Controls.Add(this.picbox_grey2);
            this.Controls.Add(this.picbox_grey3);
            this.Controls.Add(this.picbox_grey1);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.Lbl_heading);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Billing";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cardnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_creditcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_paypal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_giftcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_grey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_grey3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_grey1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_cardnumber;
        private System.Windows.Forms.PictureBox picbox_num2;
        private System.Windows.Forms.PictureBox picbox_num1;
        private System.Windows.Forms.TextBox txt_cardnumber;
        private System.Windows.Forms.TextBox txt_nameoncard;
        private System.Windows.Forms.TextBox txt_expmonth;
        private System.Windows.Forms.TextBox txt_cvvnumber;
        private System.Windows.Forms.TextBox txt_expday;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label lbl_expmonth;
        private System.Windows.Forms.Label lbl_expday;
        private System.Windows.Forms.Label lbl_cvvnumber;
        private System.Windows.Forms.Label lbl_cardnumber;
        private System.Windows.Forms.Label lbl_nameoncard;
        private System.Windows.Forms.Label lbl_creditcardinfo;
        private System.Windows.Forms.Label lbl_address1;
        private System.Windows.Forms.Label lbl_address2;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_bilingaddress;
        private System.Windows.Forms.Label lbl_paypal;
        private System.Windows.Forms.Label lbl_giftcard;
        private System.Windows.Forms.Label lbl_creditcard;
        private System.Windows.Forms.PictureBox picbox_creditcard;
        private System.Windows.Forms.PictureBox picbox_paypal;
        private System.Windows.Forms.PictureBox picbox_giftcard;
        private System.Windows.Forms.PictureBox picbox_grey2;
        private System.Windows.Forms.PictureBox picbox_grey3;
        private System.Windows.Forms.PictureBox picbox_grey1;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label Lbl_heading;
    }
}