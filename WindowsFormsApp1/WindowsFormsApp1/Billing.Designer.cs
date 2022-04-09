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
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.lbl_creditcardinfo = new System.Windows.Forms.Label();
            this.lbl_address1 = new System.Windows.Forms.Label();
            this.lbl_address2 = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_bilingaddress = new System.Windows.Forms.Label();
            this.lbl_paypal = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.Lbl_heading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picbox_giftcard = new System.Windows.Forms.PictureBox();
            this.picbox_paypal = new System.Windows.Forms.PictureBox();
            this.picbox_cardnumber = new System.Windows.Forms.PictureBox();
            this.picbox_num2 = new System.Windows.Forms.PictureBox();
            this.picbox_num1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_giftcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_paypal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cardnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_address1
            // 
            this.txt_address1.BackColor = System.Drawing.Color.White;
            this.txt_address1.Location = new System.Drawing.Point(31, 191);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(470, 22);
            this.txt_address1.TabIndex = 57;
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(31, 262);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(470, 22);
            this.txt_address2.TabIndex = 56;
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.Color.White;
            this.txt_fullname.Location = new System.Drawing.Point(31, 113);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(470, 22);
            this.txt_fullname.TabIndex = 55;
            // 
            // lbl_creditcardinfo
            // 
            this.lbl_creditcardinfo.AutoSize = true;
            this.lbl_creditcardinfo.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creditcardinfo.Location = new System.Drawing.Point(199, 19);
            this.lbl_creditcardinfo.Name = "lbl_creditcardinfo";
            this.lbl_creditcardinfo.Size = new System.Drawing.Size(211, 26);
            this.lbl_creditcardinfo.TabIndex = 49;
            this.lbl_creditcardinfo.Text = "Credit Card Info";
            // 
            // lbl_address1
            // 
            this.lbl_address1.AutoSize = true;
            this.lbl_address1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address1.Location = new System.Drawing.Point(29, 153);
            this.lbl_address1.Name = "lbl_address1";
            this.lbl_address1.Size = new System.Drawing.Size(110, 20);
            this.lbl_address1.TabIndex = 48;
            this.lbl_address1.Text = "ADDRESS 1";
            // 
            // lbl_address2
            // 
            this.lbl_address2.AutoSize = true;
            this.lbl_address2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address2.Location = new System.Drawing.Point(29, 227);
            this.lbl_address2.Name = "lbl_address2";
            this.lbl_address2.Size = new System.Drawing.Size(110, 20);
            this.lbl_address2.TabIndex = 47;
            this.lbl_address2.Text = "ADDRESS 2";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(29, 77);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(111, 20);
            this.lbl_fullname.TabIndex = 46;
            this.lbl_fullname.Text = "FULL NAME";
            // 
            // lbl_bilingaddress
            // 
            this.lbl_bilingaddress.AutoSize = true;
            this.lbl_bilingaddress.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bilingaddress.Location = new System.Drawing.Point(194, 19);
            this.lbl_bilingaddress.Name = "lbl_bilingaddress";
            this.lbl_bilingaddress.Size = new System.Drawing.Size(194, 26);
            this.lbl_bilingaddress.TabIndex = 45;
            this.lbl_bilingaddress.Text = "Billing address";
            // 
            // lbl_paypal
            // 
            this.lbl_paypal.AutoSize = true;
            this.lbl_paypal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_paypal.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paypal.Location = new System.Drawing.Point(35, 84);
            this.lbl_paypal.Name = "lbl_paypal";
            this.lbl_paypal.Size = new System.Drawing.Size(68, 20);
            this.lbl_paypal.TabIndex = 44;
            this.lbl_paypal.Text = "PayPal";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_description.Location = new System.Drawing.Point(354, 114);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(530, 50);
            this.lbl_description.TabIndex = 35;
            this.lbl_description.Text = "Choose the payment option below and fill out the\r\n                      appropria" +
    "te information";
            // 
            // Lbl_heading
            // 
            this.Lbl_heading.AutoSize = true;
            this.Lbl_heading.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_heading.Location = new System.Drawing.Point(457, 42);
            this.Lbl_heading.Name = "Lbl_heading";
            this.Lbl_heading.Size = new System.Drawing.Size(301, 54);
            this.Lbl_heading.TabIndex = 34;
            this.Lbl_heading.Text = "Billing Info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.picbox_paypal);
            this.panel1.Controls.Add(this.lbl_paypal);
            this.panel1.Location = new System.Drawing.Point(724, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 114);
            this.panel1.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picbox_giftcard);
            this.panel2.Location = new System.Drawing.Point(532, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 114);
            this.panel2.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Gift Card";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(334, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 114);
            this.panel3.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Gift Card";
            // 
            // picbox_giftcard
            // 
            this.picbox_giftcard.BackColor = System.Drawing.Color.LightGray;
            this.picbox_giftcard.Image = ((System.Drawing.Image)(resources.GetObject("picbox_giftcard.Image")));
            this.picbox_giftcard.Location = new System.Drawing.Point(29, 12);
            this.picbox_giftcard.Name = "picbox_giftcard";
            this.picbox_giftcard.Size = new System.Drawing.Size(73, 57);
            this.picbox_giftcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_giftcard.TabIndex = 39;
            this.picbox_giftcard.TabStop = false;
            // 
            // picbox_paypal
            // 
            this.picbox_paypal.BackColor = System.Drawing.Color.LightGray;
            this.picbox_paypal.Image = ((System.Drawing.Image)(resources.GetObject("picbox_paypal.Image")));
            this.picbox_paypal.Location = new System.Drawing.Point(34, 13);
            this.picbox_paypal.Name = "picbox_paypal";
            this.picbox_paypal.Size = new System.Drawing.Size(68, 57);
            this.picbox_paypal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_paypal.TabIndex = 40;
            this.picbox_paypal.TabStop = false;
            // 
            // picbox_cardnumber
            // 
            this.picbox_cardnumber.BackColor = System.Drawing.Color.White;
            this.picbox_cardnumber.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cardnumber.Image")));
            this.picbox_cardnumber.Location = new System.Drawing.Point(471, 191);
            this.picbox_cardnumber.Name = "picbox_cardnumber";
            this.picbox_cardnumber.Size = new System.Drawing.Size(36, 21);
            this.picbox_cardnumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_cardnumber.TabIndex = 65;
            this.picbox_cardnumber.TabStop = false;
            // 
            // picbox_num2
            // 
            this.picbox_num2.Image = ((System.Drawing.Image)(resources.GetObject("picbox_num2.Image")));
            this.picbox_num2.Location = new System.Drawing.Point(114, 19);
            this.picbox_num2.Name = "picbox_num2";
            this.picbox_num2.Size = new System.Drawing.Size(34, 26);
            this.picbox_num2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_num2.TabIndex = 64;
            this.picbox_num2.TabStop = false;
            // 
            // picbox_num1
            // 
            this.picbox_num1.Image = ((System.Drawing.Image)(resources.GetObject("picbox_num1.Image")));
            this.picbox_num1.Location = new System.Drawing.Point(133, 17);
            this.picbox_num1.Name = "picbox_num1";
            this.picbox_num1.Size = new System.Drawing.Size(34, 26);
            this.picbox_num1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_num1.TabIndex = 63;
            this.picbox_num1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.lbl_bilingaddress);
            this.panel4.Controls.Add(this.picbox_num1);
            this.panel4.Controls.Add(this.lbl_fullname);
            this.panel4.Controls.Add(this.txt_fullname);
            this.panel4.Controls.Add(this.lbl_address1);
            this.panel4.Controls.Add(this.txt_address1);
            this.panel4.Controls.Add(this.lbl_address2);
            this.panel4.Controls.Add(this.txt_address2);
            this.panel4.Location = new System.Drawing.Point(38, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 342);
            this.panel4.TabIndex = 69;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.picbox_cardnumber);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.picbox_num2);
            this.panel5.Controls.Add(this.lbl_creditcardinfo);
            this.panel5.Location = new System.Drawing.Point(610, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 342);
            this.panel5.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "NAME ON CARD";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(32, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 22);
            this.textBox1.TabIndex = 66;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(37, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(470, 22);
            this.textBox2.TabIndex = 67;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 22);
            this.textBox3.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "CARD NUMBER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "CVV NUMBER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "EXP. MONTH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(366, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "EXP. DAY";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(204, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 22);
            this.textBox4.TabIndex = 73;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(370, 262);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 22);
            this.textBox5.TabIndex = 74;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 715);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.Lbl_heading);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Billing";
            this.Text = "Billing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_giftcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_paypal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cardnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_cardnumber;
        private System.Windows.Forms.PictureBox picbox_num2;
        private System.Windows.Forms.PictureBox picbox_num1;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label lbl_creditcardinfo;
        private System.Windows.Forms.Label lbl_address1;
        private System.Windows.Forms.Label lbl_address2;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_bilingaddress;
        private System.Windows.Forms.Label lbl_paypal;
        private System.Windows.Forms.PictureBox picbox_paypal;
        private System.Windows.Forms.PictureBox picbox_giftcard;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label Lbl_heading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}