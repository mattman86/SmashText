namespace SmashText
{
	partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.csvpath = new System.Windows.Forms.TextBox();
            this.csvLabel = new System.Windows.Forms.Label();
            this.usernameTip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordTip = new System.Windows.Forms.ToolTip(this.components);
            this.csvTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.categories = new System.Windows.Forms.TextBox();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.mobilePhone = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSaveLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(7, 15);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(71, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(148, 20);
            this.username.TabIndex = 1;
            this.usernameTip.SetToolTip(this.username, "The same username as your Gmail Account.\r\n\r\nExample:\r\n\r\n\"you@gmail.com\" or\r\n\"you\"" +
        "");
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameKeyDown);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(71, 38);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(148, 20);
            this.password.TabIndex = 2;
            this.passwordTip.SetToolTip(this.password, "The same password as your Gmail account.");
            this.password.UseSystemPasswordChar = true;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordKeyDown);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(144, 92);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Button1Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(225, 92);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.Button2Click);
            // 
            // csvpath
            // 
            this.csvpath.Enabled = false;
            this.csvpath.Location = new System.Drawing.Point(71, 65);
            this.csvpath.Name = "csvpath";
            this.csvpath.Size = new System.Drawing.Size(148, 20);
            this.csvpath.TabIndex = 3;
            this.csvTip.SetToolTip(this.csvpath, "The path to your exported .CSV file.\r\n\r\nExample:\r\n\"C:\\users\\[you]\\Downloads\\conta" +
        "cts.csv\"");
            this.csvpath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CsvpathKeyDown);
            // 
            // csvLabel
            // 
            this.csvLabel.AutoSize = true;
            this.csvLabel.Location = new System.Drawing.Point(12, 68);
            this.csvLabel.Name = "csvLabel";
            this.csvLabel.Size = new System.Drawing.Size(53, 13);
            this.csvLabel.TabIndex = 10;
            this.csvLabel.Text = ".CSV File:";
            // 
            // usernameTip
            // 
            this.usernameTip.ToolTipTitle = "Google Account Username";
            // 
            // passwordTip
            // 
            this.passwordTip.ToolTipTitle = "Google Account Password";
            // 
            // csvTip
            // 
            this.csvTip.ToolTipTitle = "Local .CSV File";
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "csv";
            this.openFile.FileName = "contacts.csv";
            this.openFile.Filter = "CSV File (*.csv) | *.csv";
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(225, 63);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.Button3Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 121);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Use Google Contacts";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(175, 121);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Import your own CSV";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
            // 
            // categories
            // 
            this.categories.Enabled = false;
            this.categories.Location = new System.Drawing.Point(110, 278);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(109, 20);
            this.categories.TabIndex = 13;
            this.categories.Text = "Categories";
            // 
            // emailAddress
            // 
            this.emailAddress.Enabled = false;
            this.emailAddress.Location = new System.Drawing.Point(110, 252);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(109, 20);
            this.emailAddress.TabIndex = 12;
            this.emailAddress.Text = "E-mail Address";
            // 
            // mobilePhone
            // 
            this.mobilePhone.Enabled = false;
            this.mobilePhone.Location = new System.Drawing.Point(110, 226);
            this.mobilePhone.Name = "mobilePhone";
            this.mobilePhone.Size = new System.Drawing.Size(109, 20);
            this.mobilePhone.TabIndex = 11;
            this.mobilePhone.Text = "Mobile Phone";
            // 
            // lastName
            // 
            this.lastName.Enabled = false;
            this.lastName.Location = new System.Drawing.Point(110, 200);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(109, 20);
            this.lastName.TabIndex = 10;
            this.lastName.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.Enabled = false;
            this.firstName.Location = new System.Drawing.Point(110, 174);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(109, 20);
            this.firstName.TabIndex = 9;
            this.firstName.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mobile Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "E-mail Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Categories:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Set the headings for your CSV file.";
            // 
            // cbSaveLogin
            // 
            this.cbSaveLogin.AutoSize = true;
            this.cbSaveLogin.Location = new System.Drawing.Point(225, 40);
            this.cbSaveLogin.Name = "cbSaveLogin";
            this.cbSaveLogin.Size = new System.Drawing.Size(72, 17);
            this.cbSaveLogin.TabIndex = 26;
            this.cbSaveLogin.Text = "Save Info";
            this.cbSaveLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 146);
            this.ControlBox = false;
            this.Controls.Add(this.cbSaveLogin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.mobilePhone);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.csvLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.csvpath);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Label passwordLabel;
		public System.Windows.Forms.Button loginButton;
		public System.Windows.Forms.TextBox username;
		public System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox csvpath;
        private System.Windows.Forms.Label csvLabel;
        private System.Windows.Forms.ToolTip usernameTip;
        private System.Windows.Forms.ToolTip passwordTip;
        private System.Windows.Forms.ToolTip csvTip;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button browseButton;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.TextBox categories;
        public System.Windows.Forms.TextBox emailAddress;
        public System.Windows.Forms.TextBox mobilePhone;
        public System.Windows.Forms.TextBox lastName;
        public System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbSaveLogin;
	}
}