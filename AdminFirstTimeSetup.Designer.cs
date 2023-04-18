namespace MikuRetailPro
{
    partial class AdminOwnerSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOwnerSetup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quitregbtn = new System.Windows.Forms.Button();
            this.regusrbtn = new System.Windows.Forms.Button();
            this.usrpwdreglabel = new System.Windows.Forms.Label();
            this.usrusnreglabel = new System.Windows.Forms.Label();
            this.adregpass = new System.Windows.Forms.TextBox();
            this.adregname = new System.Windows.Forms.TextBox();
            this.adregpassre = new System.Windows.Forms.TextBox();
            this.usrusnrepwdlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // quitregbtn
            // 
            this.quitregbtn.Location = new System.Drawing.Point(507, 343);
            this.quitregbtn.Name = "quitregbtn";
            this.quitregbtn.Size = new System.Drawing.Size(120, 32);
            this.quitregbtn.TabIndex = 13;
            this.quitregbtn.Text = "Quit";
            this.quitregbtn.UseVisualStyleBackColor = true;
            this.quitregbtn.Click += new System.EventHandler(this.quitregbtn_Click);
            // 
            // regusrbtn
            // 
            this.regusrbtn.Location = new System.Drawing.Point(175, 343);
            this.regusrbtn.Name = "regusrbtn";
            this.regusrbtn.Size = new System.Drawing.Size(120, 32);
            this.regusrbtn.TabIndex = 12;
            this.regusrbtn.Text = "Register";
            this.regusrbtn.UseVisualStyleBackColor = true;
            this.regusrbtn.Click += new System.EventHandler(this.regusrbtn_Click);
            // 
            // usrpwdreglabel
            // 
            this.usrpwdreglabel.AutoSize = true;
            this.usrpwdreglabel.Location = new System.Drawing.Point(172, 231);
            this.usrpwdreglabel.Name = "usrpwdreglabel";
            this.usrpwdreglabel.Size = new System.Drawing.Size(53, 13);
            this.usrpwdreglabel.TabIndex = 11;
            this.usrpwdreglabel.Text = "Password";
            // 
            // usrusnreglabel
            // 
            this.usrusnreglabel.AutoSize = true;
            this.usrusnreglabel.Location = new System.Drawing.Point(172, 181);
            this.usrusnreglabel.Name = "usrusnreglabel";
            this.usrusnreglabel.Size = new System.Drawing.Size(55, 13);
            this.usrusnreglabel.TabIndex = 10;
            this.usrusnreglabel.Text = "Username";
            // 
            // adregpass
            // 
            this.adregpass.Location = new System.Drawing.Point(175, 247);
            this.adregpass.Name = "adregpass";
            this.adregpass.PasswordChar = '●';
            this.adregpass.Size = new System.Drawing.Size(452, 20);
            this.adregpass.TabIndex = 9;
            // 
            // adregname
            // 
            this.adregname.Location = new System.Drawing.Point(175, 197);
            this.adregname.Name = "adregname";
            this.adregname.Size = new System.Drawing.Size(452, 20);
            this.adregname.TabIndex = 8;
            // 
            // adregpassre
            // 
            this.adregpassre.Location = new System.Drawing.Point(175, 292);
            this.adregpassre.Name = "adregpassre";
            this.adregpassre.PasswordChar = '●';
            this.adregpassre.Size = new System.Drawing.Size(452, 20);
            this.adregpassre.TabIndex = 15;
            // 
            // usrusnrepwdlabel
            // 
            this.usrusnrepwdlabel.AutoSize = true;
            this.usrusnrepwdlabel.Location = new System.Drawing.Point(174, 276);
            this.usrusnrepwdlabel.Name = "usrusnrepwdlabel";
            this.usrusnrepwdlabel.Size = new System.Drawing.Size(97, 13);
            this.usrusnrepwdlabel.TabIndex = 16;
            this.usrusnrepwdlabel.Text = "Re-enter Password";
            // 
            // AdminOwnerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usrusnrepwdlabel);
            this.Controls.Add(this.adregpassre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitregbtn);
            this.Controls.Add(this.regusrbtn);
            this.Controls.Add(this.usrpwdreglabel);
            this.Controls.Add(this.usrusnreglabel);
            this.Controls.Add(this.adregpass);
            this.Controls.Add(this.adregname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminOwnerSetup";
            this.Text = "AdminOwnerSetup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quitregbtn;
        private System.Windows.Forms.Button regusrbtn;
        private System.Windows.Forms.Label usrpwdreglabel;
        private System.Windows.Forms.Label usrusnreglabel;
        private System.Windows.Forms.TextBox adregpass;
        private System.Windows.Forms.TextBox adregname;
        private System.Windows.Forms.TextBox adregpassre;
        private System.Windows.Forms.Label usrusnrepwdlabel;
    }
}