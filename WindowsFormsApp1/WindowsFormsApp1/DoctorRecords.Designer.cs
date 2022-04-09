using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class NewForm3
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(257, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 181);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor Records";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewForm3";
            this.Text = "Doctor Records";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;

        #endregion
    }
}