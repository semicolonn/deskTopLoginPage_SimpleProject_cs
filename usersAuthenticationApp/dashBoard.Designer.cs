namespace usersAuthenticationApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cPasswortBtn = new System.Windows.Forms.Button();
            this.cPassword = new System.Windows.Forms.TextBox();
            this.cplabel3 = new System.Windows.Forms.Label();
            this.nplabel4 = new System.Windows.Forms.Label();
            this.nPassword = new System.Windows.Forms.TextBox();
            this.vplabel5 = new System.Windows.Forms.Label();
            this.vPassword = new System.Windows.Forms.TextBox();
            this.linkLabel2logout = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.deactlabel3 = new System.Windows.Forms.Label();
            this.deactiveText = new System.Windows.Forms.TextBox();
            this.button1Deact = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.WelcomeLabel.Location = new System.Drawing.Point(200, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(138, 28);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "My Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "---------------------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome, Dear User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(20, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cPasswortBtn
            // 
            this.cPasswortBtn.Location = new System.Drawing.Point(386, 196);
            this.cPasswortBtn.Name = "cPasswortBtn";
            this.cPasswortBtn.Size = new System.Drawing.Size(128, 23);
            this.cPasswortBtn.TabIndex = 4;
            this.cPasswortBtn.Text = "Change Password";
            this.cPasswortBtn.UseVisualStyleBackColor = true;
            this.cPasswortBtn.Click += new System.EventHandler(this.cPasswortBtn_Click);
            // 
            // cPassword
            // 
            this.cPassword.Location = new System.Drawing.Point(386, 113);
            this.cPassword.Name = "cPassword";
            this.cPassword.PasswordChar = '*';
            this.cPassword.Size = new System.Drawing.Size(128, 20);
            this.cPassword.TabIndex = 5;
            // 
            // cplabel3
            // 
            this.cplabel3.AutoSize = true;
            this.cplabel3.Location = new System.Drawing.Point(279, 113);
            this.cplabel3.Name = "cplabel3";
            this.cplabel3.Size = new System.Drawing.Size(93, 13);
            this.cplabel3.TabIndex = 6;
            this.cplabel3.Text = "Current Password:";
            // 
            // nplabel4
            // 
            this.nplabel4.AutoSize = true;
            this.nplabel4.Location = new System.Drawing.Point(291, 139);
            this.nplabel4.Name = "nplabel4";
            this.nplabel4.Size = new System.Drawing.Size(81, 13);
            this.nplabel4.TabIndex = 8;
            this.nplabel4.Text = "New Password:";
            // 
            // nPassword
            // 
            this.nPassword.Location = new System.Drawing.Point(386, 139);
            this.nPassword.Name = "nPassword";
            this.nPassword.PasswordChar = '*';
            this.nPassword.Size = new System.Drawing.Size(128, 20);
            this.nPassword.TabIndex = 7;
            // 
            // vplabel5
            // 
            this.vplabel5.AutoSize = true;
            this.vplabel5.Location = new System.Drawing.Point(287, 165);
            this.vplabel5.Name = "vplabel5";
            this.vplabel5.Size = new System.Drawing.Size(85, 13);
            this.vplabel5.TabIndex = 10;
            this.vplabel5.Text = "Verify Password:";
            // 
            // vPassword
            // 
            this.vPassword.Location = new System.Drawing.Point(386, 165);
            this.vPassword.Name = "vPassword";
            this.vPassword.PasswordChar = '*';
            this.vPassword.Size = new System.Drawing.Size(128, 20);
            this.vPassword.TabIndex = 9;
            // 
            // linkLabel2logout
            // 
            this.linkLabel2logout.AutoSize = true;
            this.linkLabel2logout.Location = new System.Drawing.Point(491, 20);
            this.linkLabel2logout.Name = "linkLabel2logout";
            this.linkLabel2logout.Size = new System.Drawing.Size(40, 13);
            this.linkLabel2logout.TabIndex = 11;
            this.linkLabel2logout.TabStop = true;
            this.linkLabel2logout.Text = "Logout";
            this.linkLabel2logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(6, 53);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(93, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Deactive Account";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // deactlabel3
            // 
            this.deactlabel3.AutoSize = true;
            this.deactlabel3.Location = new System.Drawing.Point(296, 228);
            this.deactlabel3.Name = "deactlabel3";
            this.deactlabel3.Size = new System.Drawing.Size(76, 13);
            this.deactlabel3.TabIndex = 14;
            this.deactlabel3.Text = "Email Address:";
            // 
            // deactiveText
            // 
            this.deactiveText.Location = new System.Drawing.Point(386, 228);
            this.deactiveText.Name = "deactiveText";
            this.deactiveText.Size = new System.Drawing.Size(128, 20);
            this.deactiveText.TabIndex = 13;
            // 
            // button1Deact
            // 
            this.button1Deact.Location = new System.Drawing.Point(386, 254);
            this.button1Deact.Name = "button1Deact";
            this.button1Deact.Size = new System.Drawing.Size(128, 23);
            this.button1Deact.TabIndex = 12;
            this.button1Deact.Text = "Deactive Account";
            this.button1Deact.UseVisualStyleBackColor = true;
            this.button1Deact.Click += new System.EventHandler(this.button1Deact_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deactlabel3);
            this.Controls.Add(this.deactiveText);
            this.Controls.Add(this.button1Deact);
            this.Controls.Add(this.linkLabel2logout);
            this.Controls.Add(this.vplabel5);
            this.Controls.Add(this.vPassword);
            this.Controls.Add(this.nplabel4);
            this.Controls.Add(this.nPassword);
            this.Controls.Add(this.cplabel3);
            this.Controls.Add(this.cPassword);
            this.Controls.Add(this.cPasswortBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeLabel);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button cPasswortBtn;
        private System.Windows.Forms.TextBox cPassword;
        private System.Windows.Forms.Label cplabel3;
        private System.Windows.Forms.Label nplabel4;
        private System.Windows.Forms.TextBox nPassword;
        private System.Windows.Forms.Label vplabel5;
        private System.Windows.Forms.TextBox vPassword;
        private System.Windows.Forms.LinkLabel linkLabel2logout;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label deactlabel3;
        private System.Windows.Forms.TextBox deactiveText;
        private System.Windows.Forms.Button button1Deact;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}