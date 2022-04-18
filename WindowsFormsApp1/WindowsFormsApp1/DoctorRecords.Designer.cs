using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class DoctorRecords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDocName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmgcyCont = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhn = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(32, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 29);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(29, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 29);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctor ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Profession";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Emergency Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(559, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(29, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1194, 47);
            this.panel3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Medical Visit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 43);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doctor Records";
            // 
            // txtDocId
            // 
            this.txtDocId.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDocId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocId.DefaultText = "";
            this.txtDocId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocId.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDocId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocId.ForeColor = System.Drawing.Color.Black;
            this.txtDocId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocId.Location = new System.Drawing.Point(149, 135);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.PasswordChar = '\0';
            this.txtDocId.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDocId.PlaceholderText = "";
            this.txtDocId.SelectedText = "";
            this.txtDocId.Size = new System.Drawing.Size(370, 32);
            this.txtDocId.TabIndex = 17;
            // 
            // txtDocName
            // 
            this.txtDocName.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDocName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocName.DefaultText = "";
            this.txtDocName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocName.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDocName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocName.ForeColor = System.Drawing.Color.Black;
            this.txtDocName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocName.Location = new System.Drawing.Point(149, 194);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.PasswordChar = '\0';
            this.txtDocName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDocName.PlaceholderText = "";
            this.txtDocName.SelectedText = "";
            this.txtDocName.Size = new System.Drawing.Size(370, 32);
            this.txtDocName.TabIndex = 18;
            // 
            // txtProf
            // 
            this.txtProf.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtProf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProf.DefaultText = "";
            this.txtProf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProf.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtProf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProf.ForeColor = System.Drawing.Color.Black;
            this.txtProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProf.Location = new System.Drawing.Point(149, 250);
            this.txtProf.Name = "txtProf";
            this.txtProf.PasswordChar = '\0';
            this.txtProf.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProf.PlaceholderText = "";
            this.txtProf.SelectedText = "";
            this.txtProf.Size = new System.Drawing.Size(370, 32);
            this.txtProf.TabIndex = 19;
            // 
            // txtEmgcyCont
            // 
            this.txtEmgcyCont.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtEmgcyCont.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmgcyCont.DefaultText = "";
            this.txtEmgcyCont.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmgcyCont.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmgcyCont.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmgcyCont.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmgcyCont.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEmgcyCont.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmgcyCont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmgcyCont.ForeColor = System.Drawing.Color.Black;
            this.txtEmgcyCont.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmgcyCont.Location = new System.Drawing.Point(853, 135);
            this.txtEmgcyCont.Name = "txtEmgcyCont";
            this.txtEmgcyCont.PasswordChar = '\0';
            this.txtEmgcyCont.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmgcyCont.PlaceholderText = "";
            this.txtEmgcyCont.SelectedText = "";
            this.txtEmgcyCont.Size = new System.Drawing.Size(370, 32);
            this.txtEmgcyCont.TabIndex = 20;
            // 
            // txtPhn
            // 
            this.txtPhn.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPhn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhn.DefaultText = "";
            this.txtPhn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPhn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhn.ForeColor = System.Drawing.Color.Black;
            this.txtPhn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhn.Location = new System.Drawing.Point(853, 194);
            this.txtPhn.Name = "txtPhn";
            this.txtPhn.PasswordChar = '\0';
            this.txtPhn.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPhn.PlaceholderText = "";
            this.txtPhn.SelectedText = "";
            this.txtPhn.Size = new System.Drawing.Size(370, 32);
            this.txtPhn.TabIndex = 21;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1016, 251);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(207, 31);
            this.guna2GradientButton1.TabIndex = 22;
            this.guna2GradientButton1.Text = "Confirm";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // DoctorRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 675);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.txtPhn);
            this.Controls.Add(this.txtEmgcyCont);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.txtDocName);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoctorRecords";
            this.Text = "Doctor Records";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDocId;
        private Guna.UI2.WinForms.Guna2TextBox txtDocName;
        private Guna.UI2.WinForms.Guna2TextBox txtProf;
        private Guna.UI2.WinForms.Guna2TextBox txtEmgcyCont;
        private Guna.UI2.WinForms.Guna2TextBox txtPhn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}