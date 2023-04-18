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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usrusnlabel = new System.Windows.Forms.Label();
            this.usrpwdlabel = new System.Windows.Forms.Label();
            this.loginusrbtn = new System.Windows.Forms.Button();
            this.quitusrbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setupbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(452, 20);
            this.textBox2.TabIndex = 1;
            // 
            // usrusnlabel
            // 
            this.usrusnlabel.AutoSize = true;
            this.usrusnlabel.Location = new System.Drawing.Point(168, 159);
            this.usrusnlabel.Name = "usrusnlabel";
            this.usrusnlabel.Size = new System.Drawing.Size(55, 13);
            this.usrusnlabel.TabIndex = 2;
            this.usrusnlabel.Text = "Username";
            // 
            // usrpwdlabel
            // 
            this.usrpwdlabel.AutoSize = true;
            this.usrpwdlabel.Location = new System.Drawing.Point(168, 209);
            this.usrpwdlabel.Name = "usrpwdlabel";
            this.usrpwdlabel.Size = new System.Drawing.Size(53, 13);
            this.usrpwdlabel.TabIndex = 3;
            this.usrpwdlabel.Text = "Password";
            // 
            // loginusrbtn
            // 
            this.loginusrbtn.Location = new System.Drawing.Point(171, 273);
            this.loginusrbtn.Name = "loginusrbtn";
            this.loginusrbtn.Size = new System.Drawing.Size(120, 32);
            this.loginusrbtn.TabIndex = 4;
            this.loginusrbtn.Text = "Login";
            this.loginusrbtn.UseVisualStyleBackColor = true;
            // 
            // quitusrbtn
            // 
            this.quitusrbtn.Location = new System.Drawing.Point(503, 273);
            this.quitusrbtn.Name = "quitusrbtn";
            this.quitusrbtn.Size = new System.Drawing.Size(120, 32);
            this.quitusrbtn.TabIndex = 5;
            this.quitusrbtn.Text = "Quit";
            this.quitusrbtn.UseVisualStyleBackColor = true;
            this.quitusrbtn.Click += new System.EventHandler(this.quitusrbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // setupbtn
            // 
            this.setupbtn.Location = new System.Drawing.Point(12, 415);
            this.setupbtn.Name = "setupbtn";
            this.setupbtn.Size = new System.Drawing.Size(75, 23);
            this.setupbtn.TabIndex = 8;
            this.setupbtn.Text = "Setup";
            this.setupbtn.UseVisualStyleBackColor = true;
            this.setupbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsrLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setupbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitusrbtn);
            this.Controls.Add(this.loginusrbtn);
            this.Controls.Add(this.usrpwdlabel);
            this.Controls.Add(this.usrusnlabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsrLoginUI";
            this.Text = "NovaRetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label usrusnlabel;
        private System.Windows.Forms.Label usrpwdlabel;
        private System.Windows.Forms.Button loginusrbtn;
        private System.Windows.Forms.Button quitusrbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button setupbtn;
    }
}

