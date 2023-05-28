namespace MikuRetailPro
{
    partial class ACP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACP));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ARS_DGV = new System.Windows.Forms.DataGridView();
            this.ACPTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RS_PWD = new System.Windows.Forms.Button();
            this.acptb3 = new System.Windows.Forms.TextBox();
            this.acptb2 = new System.Windows.Forms.TextBox();
            this.acptb1 = new System.Windows.Forms.TextBox();
            this.RS_PWD_DGV = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GET_DATA = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RF_DATA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_Staff = new System.Windows.Forms.Button();
            this.Rm_Staff = new System.Windows.Forms.Button();
            this.GETSTAFF_DATA = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ED_Staff = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometown1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARS_DGV)).BeginInit();
            this.ACPTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_PWD_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.ED_Staff);
            this.tabPage2.Controls.Add(this.GETSTAFF_DATA);
            this.tabPage2.Controls.Add(this.Rm_Staff);
            this.tabPage2.Controls.Add(this.Add_Staff);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.ARS_DGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add/Remove Staff ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ARS_DGV
            // 
            this.ARS_DGV.AllowUserToAddRows = false;
            this.ARS_DGV.AllowUserToDeleteRows = false;
            this.ARS_DGV.AllowUserToOrderColumns = true;
            this.ARS_DGV.AllowUserToResizeColumns = false;
            this.ARS_DGV.AllowUserToResizeRows = false;
            this.ARS_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ARS_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.name1,
            this.age1,
            this.hometown1,
            this.gender1,
            this.contact1,
            this.citizenid});
            this.ARS_DGV.Location = new System.Drawing.Point(440, 6);
            this.ARS_DGV.Name = "ARS_DGV";
            this.ARS_DGV.ReadOnly = true;
            this.ARS_DGV.Size = new System.Drawing.Size(322, 388);
            this.ARS_DGV.TabIndex = 1;
            // 
            // ACPTabs
            // 
            this.ACPTabs.Controls.Add(this.tabPage1);
            this.ACPTabs.Controls.Add(this.tabPage2);
            this.ACPTabs.Controls.Add(this.tabPage3);
            this.ACPTabs.Location = new System.Drawing.Point(12, 12);
            this.ACPTabs.Name = "ACPTabs";
            this.ACPTabs.SelectedIndex = 0;
            this.ACPTabs.Size = new System.Drawing.Size(776, 426);
            this.ACPTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RF_DATA);
            this.tabPage1.Controls.Add(this.GET_DATA);
            this.tabPage1.Controls.Add(this.RS_PWD);
            this.tabPage1.Controls.Add(this.acptb3);
            this.tabPage1.Controls.Add(this.acptb2);
            this.tabPage1.Controls.Add(this.acptb1);
            this.tabPage1.Controls.Add(this.RS_PWD_DGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ResetPassword";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RS_PWD
            // 
            this.RS_PWD.Location = new System.Drawing.Point(28, 251);
            this.RS_PWD.Name = "RS_PWD";
            this.RS_PWD.Size = new System.Drawing.Size(392, 29);
            this.RS_PWD.TabIndex = 6;
            this.RS_PWD.Text = "Reset Password";
            this.RS_PWD.UseVisualStyleBackColor = true;
            this.RS_PWD.Click += new System.EventHandler(this.RS_PWD_Click);
            // 
            // acptb3
            // 
            this.acptb3.Enabled = false;
            this.acptb3.Location = new System.Drawing.Point(28, 166);
            this.acptb3.Name = "acptb3";
            this.acptb3.Size = new System.Drawing.Size(392, 20);
            this.acptb3.TabIndex = 3;
            // 
            // acptb2
            // 
            this.acptb2.Enabled = false;
            this.acptb2.Location = new System.Drawing.Point(28, 111);
            this.acptb2.Name = "acptb2";
            this.acptb2.Size = new System.Drawing.Size(392, 20);
            this.acptb2.TabIndex = 2;
            // 
            // acptb1
            // 
            this.acptb1.Enabled = false;
            this.acptb1.Location = new System.Drawing.Point(28, 63);
            this.acptb1.Name = "acptb1";
            this.acptb1.Size = new System.Drawing.Size(392, 20);
            this.acptb1.TabIndex = 1;
            // 
            // RS_PWD_DGV
            // 
            this.RS_PWD_DGV.AllowUserToAddRows = false;
            this.RS_PWD_DGV.AllowUserToDeleteRows = false;
            this.RS_PWD_DGV.AllowUserToOrderColumns = true;
            this.RS_PWD_DGV.AllowUserToResizeColumns = false;
            this.RS_PWD_DGV.AllowUserToResizeRows = false;
            this.RS_PWD_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RS_PWD_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.id,
            this.role});
            this.RS_PWD_DGV.Location = new System.Drawing.Point(471, 6);
            this.RS_PWD_DGV.Name = "RS_PWD_DGV";
            this.RS_PWD_DGV.ReadOnly = true;
            this.RS_PWD_DGV.Size = new System.Drawing.Size(291, 388);
            this.RS_PWD_DGV.TabIndex = 0;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // GET_DATA
            // 
            this.GET_DATA.Location = new System.Drawing.Point(28, 216);
            this.GET_DATA.Name = "GET_DATA";
            this.GET_DATA.Size = new System.Drawing.Size(392, 29);
            this.GET_DATA.TabIndex = 7;
            this.GET_DATA.Text = "GetData";
            this.GET_DATA.UseVisualStyleBackColor = true;
            this.GET_DATA.Click += new System.EventHandler(this.button1_Click);
            // 
            // RF_DATA
            // 
            this.RF_DATA.Location = new System.Drawing.Point(28, 286);
            this.RF_DATA.Name = "RF_DATA";
            this.RF_DATA.Size = new System.Drawing.Size(392, 29);
            this.RF_DATA.TabIndex = 8;
            this.RF_DATA.Text = "Refresh";
            this.RF_DATA.UseVisualStyleBackColor = true;
            this.RF_DATA.Click += new System.EventHandler(this.RF_DATA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(23, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(23, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(23, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(393, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(23, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(393, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(23, 272);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(393, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(23, 225);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(393, 20);
            this.textBox6.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(92, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(166, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Remove";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hometown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(23, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(23, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CitizenID";
            // 
            // Add_Staff
            // 
            this.Add_Staff.Enabled = false;
            this.Add_Staff.Location = new System.Drawing.Point(23, 315);
            this.Add_Staff.Name = "Add_Staff";
            this.Add_Staff.Size = new System.Drawing.Size(167, 33);
            this.Add_Staff.TabIndex = 16;
            this.Add_Staff.Text = "Add Staff";
            this.Add_Staff.UseVisualStyleBackColor = true;
            this.Add_Staff.Click += new System.EventHandler(this.Add_Staff_Click);
            // 
            // Rm_Staff
            // 
            this.Rm_Staff.Enabled = false;
            this.Rm_Staff.Location = new System.Drawing.Point(249, 315);
            this.Rm_Staff.Name = "Rm_Staff";
            this.Rm_Staff.Size = new System.Drawing.Size(167, 33);
            this.Rm_Staff.TabIndex = 17;
            this.Rm_Staff.Text = "Remove Staff";
            this.Rm_Staff.UseVisualStyleBackColor = true;
            this.Rm_Staff.Click += new System.EventHandler(this.Rm_Staff_Click);
            // 
            // GETSTAFF_DATA
            // 
            this.GETSTAFF_DATA.Enabled = false;
            this.GETSTAFF_DATA.Location = new System.Drawing.Point(23, 354);
            this.GETSTAFF_DATA.Name = "GETSTAFF_DATA";
            this.GETSTAFF_DATA.Size = new System.Drawing.Size(167, 33);
            this.GETSTAFF_DATA.TabIndex = 18;
            this.GETSTAFF_DATA.Text = "GetData";
            this.GETSTAFF_DATA.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BindingAccount";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ED_Staff
            // 
            this.ED_Staff.Enabled = false;
            this.ED_Staff.Location = new System.Drawing.Point(249, 354);
            this.ED_Staff.Name = "ED_Staff";
            this.ED_Staff.Size = new System.Drawing.Size(167, 33);
            this.ED_Staff.TabIndex = 19;
            this.ED_Staff.Text = "Edit";
            this.ED_Staff.UseVisualStyleBackColor = true;
            this.ED_Staff.Click += new System.EventHandler(this.ED_Staff_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(249, 7);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 17);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Edit";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // id1
            // 
            this.id1.HeaderText = "ID";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            // 
            // name1
            // 
            this.name1.HeaderText = "Name";
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            // 
            // age1
            // 
            this.age1.HeaderText = "Age";
            this.age1.Name = "age1";
            this.age1.ReadOnly = true;
            // 
            // hometown1
            // 
            this.hometown1.HeaderText = "Hometown";
            this.hometown1.Name = "hometown1";
            this.hometown1.ReadOnly = true;
            // 
            // gender1
            // 
            this.gender1.HeaderText = "Gender";
            this.gender1.Name = "gender1";
            this.gender1.ReadOnly = true;
            // 
            // contact1
            // 
            this.contact1.HeaderText = "Contact";
            this.contact1.Name = "contact1";
            this.contact1.ReadOnly = true;
            // 
            // citizenid
            // 
            this.citizenid.HeaderText = "CitizenID";
            this.citizenid.Name = "citizenid";
            this.citizenid.ReadOnly = true;
            // 
            // ACP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ACPTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ACP";
            this.Text = "NovaRetail-AdminControlPanel";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARS_DGV)).EndInit();
            this.ACPTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_PWD_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl ACPTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView RS_PWD_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridView ARS_DGV;
        private System.Windows.Forms.Button RS_PWD;
        private System.Windows.Forms.TextBox acptb3;
        private System.Windows.Forms.TextBox acptb2;
        private System.Windows.Forms.TextBox acptb1;
        private System.Windows.Forms.Button GET_DATA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RF_DATA;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rm_Staff;
        private System.Windows.Forms.Button Add_Staff;
        private System.Windows.Forms.Button GETSTAFF_DATA;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button ED_Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn age1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact1;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenid;
    }
}