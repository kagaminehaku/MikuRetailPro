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
            this.usrusnlabel = new System.Windows.Forms.Label();
            this.usrpwdlabel = new System.Windows.Forms.Label();
            this.Loginusrbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.About_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usntxb
            // 
            this.usntxb.Location = new System.Drawing.Point(464, 148);
            this.usntxb.Name = "usntxb";
            this.usntxb.Size = new System.Drawing.Size(261, 20);
            this.usntxb.TabIndex = 0;
            // 
            // pwdtxb
            // 
            this.pwdtxb.Location = new System.Drawing.Point(464, 198);
            this.pwdtxb.Name = "pwdtxb";
            this.pwdtxb.PasswordChar = '●';
            this.pwdtxb.Size = new System.Drawing.Size(261, 20);
            this.pwdtxb.TabIndex = 1;
            // 
            // usrusnlabel
            // 
            this.usrusnlabel.AutoSize = true;
            this.usrusnlabel.Location = new System.Drawing.Point(461, 132);
            this.usrusnlabel.Name = "usrusnlabel";
            this.usrusnlabel.Size = new System.Drawing.Size(55, 13);
            this.usrusnlabel.TabIndex = 2;
            this.usrusnlabel.Text = "Username";
            // 
            // usrpwdlabel
            // 
            this.usrpwdlabel.AutoSize = true;
            this.usrpwdlabel.Location = new System.Drawing.Point(461, 182);
            this.usrpwdlabel.Name = "usrpwdlabel";
            this.usrpwdlabel.Size = new System.Drawing.Size(53, 13);
            this.usrpwdlabel.TabIndex = 3;
            this.usrpwdlabel.Text = "Password";
            // 
            // Loginusrbtn
            // 
            this.Loginusrbtn.Location = new System.Drawing.Point(464, 246);
            this.Loginusrbtn.Name = "Loginusrbtn";
            this.Loginusrbtn.Size = new System.Drawing.Size(261, 32);
            this.Loginusrbtn.TabIndex = 4;
            this.Loginusrbtn.Text = "Login";
            this.Loginusrbtn.UseVisualStyleBackColor = true;
            this.Loginusrbtn.Click += new System.EventHandler(this.loginusrbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // About_btn
            // 
            this.About_btn.Location = new System.Drawing.Point(738, 398);
            this.About_btn.Name = "About_btn";
            this.About_btn.Size = new System.Drawing.Size(75, 23);
            this.About_btn.TabIndex = 8;
            this.About_btn.Text = "About";
            this.About_btn.UseVisualStyleBackColor = true;
            // 
            // UsrLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 433);
            this.Controls.Add(this.About_btn);
            this.Controls.Add(this.Loginusrbtn);
            this.Controls.Add(this.usrpwdlabel);
            this.Controls.Add(this.usrusnlabel);
            this.Controls.Add(this.pwdtxb);
            this.Controls.Add(this.usntxb);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsrLoginUI";
            this.Text = "NovaRetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usntxb;
        private System.Windows.Forms.TextBox pwdtxb;
        private System.Windows.Forms.Label usrusnlabel;
        private System.Windows.Forms.Label usrpwdlabel;
        private System.Windows.Forms.Button Loginusrbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button About_btn;
    }
}

