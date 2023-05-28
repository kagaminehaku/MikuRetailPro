using System.Drawing;
using System.Windows.Forms;

namespace MikuRetailPro
{
    partial class UsrLoginUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrLoginUI));
            this.usntxb = new System.Windows.Forms.TextBox();
            this.pwdtxb = new System.Windows.Forms.TextBox();
            this.Loginusrbtn = new System.Windows.Forms.Button();
            this.About_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usrusnlabel = new System.Windows.Forms.Label();
            this.usrpwdlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usntxb
            // 
            this.usntxb.Location = new System.Drawing.Point(619, 171);
            this.usntxb.MaxLength = 20;
            this.usntxb.Name = "usntxb";
            this.usntxb.Size = new System.Drawing.Size(347, 23);
            this.usntxb.TabIndex = 0;
            // 
            // pwdtxb
            // 
            this.pwdtxb.Location = new System.Drawing.Point(619, 228);
            this.pwdtxb.MaxLength = 20;
            this.pwdtxb.Name = "pwdtxb";
            this.pwdtxb.PasswordChar = '●';
            this.pwdtxb.Size = new System.Drawing.Size(347, 23);
            this.pwdtxb.TabIndex = 1;
            // 
            // Loginusrbtn
            // 
            this.Loginusrbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Loginusrbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Loginusrbtn.Location = new System.Drawing.Point(619, 284);
            this.Loginusrbtn.Name = "Loginusrbtn";
            this.Loginusrbtn.Size = new System.Drawing.Size(349, 37);
            this.Loginusrbtn.TabIndex = 4;
            this.Loginusrbtn.Text = "Login";
            this.Loginusrbtn.UseVisualStyleBackColor = false;
            this.Loginusrbtn.Click += new System.EventHandler(this.Loginusrbtn_Click);
            // 
            // About_btn
            // 
            this.About_btn.Location = new System.Drawing.Point(984, 459);
            this.About_btn.Name = "About_btn";
            this.About_btn.Size = new System.Drawing.Size(99, 27);
            this.About_btn.TabIndex = 8;
            this.About_btn.Text = "About";
            this.About_btn.UseVisualStyleBackColor = true;
            this.About_btn.Click += new System.EventHandler(this.About_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1101, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // usrusnlabel
            // 
            this.usrusnlabel.AutoSize = true;
            this.usrusnlabel.Location = new System.Drawing.Point(615, 152);
            this.usrusnlabel.Name = "usrusnlabel";
            this.usrusnlabel.Size = new System.Drawing.Size(66, 15);
            this.usrusnlabel.TabIndex = 2;
            this.usrusnlabel.Text = "Username";
            // 
            // usrpwdlabel
            // 
            this.usrpwdlabel.AutoSize = true;
            this.usrpwdlabel.Location = new System.Drawing.Point(615, 210);
            this.usrpwdlabel.Name = "usrpwdlabel";
            this.usrpwdlabel.Size = new System.Drawing.Size(64, 15);
            this.usrpwdlabel.TabIndex = 3;
            this.usrpwdlabel.Text = "Password";
            // 
            // UsrLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 500);
            this.Controls.Add(this.About_btn);
            this.Controls.Add(this.Loginusrbtn);
            this.Controls.Add(this.usrpwdlabel);
            this.Controls.Add(this.usrusnlabel);
            this.Controls.Add(this.pwdtxb);
            this.Controls.Add(this.usntxb);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsrLoginUI";
            this.Text = "NovaRetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usntxb;
        private System.Windows.Forms.TextBox pwdtxb;
        private System.Windows.Forms.Button Loginusrbtn;
        private Button About_btn;
        private PictureBox pictureBox2;
        private Label usrusnlabel;
        private Label usrpwdlabel;
    }
}

