namespace SmashText
{
	partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.loginWindowTimer = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundSendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delayTip = new System.Windows.Forms.ToolTip(this.components);
            this.delayBox = new System.Windows.Forms.NumericUpDown();
            this.messageTip = new System.Windows.Forms.ToolTip(this.components);
            this.textMessageInputBox = new System.Windows.Forms.TextBox();
            this.messageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneNumberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.groupSelector = new System.Windows.Forms.ComboBox();
            this.selectedContacts = new System.Windows.Forms.CheckedListBox();
            this.selectAll = new System.Windows.Forms.CheckBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.savedMessagesBox = new System.Windows.Forms.ListBox();
            this.savedMessagesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charsRemaining = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactInfoLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sendTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBox)).BeginInit();
            this.messageContextMenu.SuspendLayout();
            this.savedMessagesContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginWindowTimer
            // 
            this.loginWindowTimer.Interval = 50;
            this.loginWindowTimer.Tick += new System.EventHandler(this.LoginWindowTimerTick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu.Size = new System.Drawing.Size(884, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadContactsToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.backgroundSendingToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // reloadContactsToolStripMenuItem
            // 
            this.reloadContactsToolStripMenuItem.Name = "reloadContactsToolStripMenuItem";
            this.reloadContactsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reloadContactsToolStripMenuItem.Text = "Reload &Contacts";
            this.reloadContactsToolStripMenuItem.Click += new System.EventHandler(this.reloadContactsToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // backgroundSendingToolStripMenuItem
            // 
            this.backgroundSendingToolStripMenuItem.Name = "backgroundSendingToolStripMenuItem";
            this.backgroundSendingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.backgroundSendingToolStripMenuItem.Text = "&Minimize to Tray";
            this.backgroundSendingToolStripMenuItem.Click += new System.EventHandler(this.backgroundSendingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.getToolStripMenuItem,
            this.donateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItem);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("getToolStripMenuItem.Image")));
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.getToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.getToolStripMenuItem.Text = "&Get Help";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getHelpToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.donateToolStripMenuItem.Text = "&Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // delayTip
            // 
            this.delayTip.ShowAlways = true;
            this.delayTip.ToolTipTitle = "Message Delay";
            // 
            // delayBox
            // 
            this.delayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delayBox.BackColor = System.Drawing.SystemColors.Window;
            this.delayBox.Enabled = false;
            this.delayBox.Location = new System.Drawing.Point(335, 244);
            this.delayBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.delayBox.Name = "delayBox";
            this.delayBox.ReadOnly = true;
            this.delayBox.Size = new System.Drawing.Size(50, 20);
            this.delayBox.TabIndex = 5;
            this.delayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayTip.SetToolTip(this.delayBox, "This delay must be at least 2 or only half of the messages will go through.\r\n\r\nTh" +
        "e larger the number, the more messages you can send in a session.");
            this.delayBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // messageTip
            // 
            this.messageTip.ToolTipTitle = "Text Message";
            // 
            // textMessageInputBox
            // 
            this.textMessageInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMessageInputBox.ContextMenuStrip = this.messageContextMenu;
            this.textMessageInputBox.Location = new System.Drawing.Point(6, 19);
            this.textMessageInputBox.MaxLength = 480;
            this.textMessageInputBox.Multiline = true;
            this.textMessageInputBox.Name = "textMessageInputBox";
            this.textMessageInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessageInputBox.Size = new System.Drawing.Size(291, 157);
            this.textMessageInputBox.TabIndex = 4;
            this.messageTip.SetToolTip(this.textMessageInputBox, "Type your message here.\r\n\r\nThe message can be up to 480 characters long.\r\n\r\nYou c" +
        "an use the following tags:\r\n{firstname}\r\n{lastname}\r\n{phone}\r\n{email}\r\n");
            this.textMessageInputBox.TextChanged += new System.EventHandler(this.TextMessageInputBoxTextChanged);
            // 
            // messageContextMenu
            // 
            this.messageContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem});
            this.messageContextMenu.Name = "messageContextMenu";
            this.messageContextMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameToolStripMenuItem1,
            this.lastNameToolStripMenuItem1,
            this.phoneNumberToolStripMenuItem1,
            this.emailAddressToolStripMenuItem1});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // firstNameToolStripMenuItem1
            // 
            this.firstNameToolStripMenuItem1.Name = "firstNameToolStripMenuItem1";
            this.firstNameToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.firstNameToolStripMenuItem1.Text = "First Name";
            this.firstNameToolStripMenuItem1.Click += new System.EventHandler(this.firstNameToolStripMenuItem1_Click);
            // 
            // lastNameToolStripMenuItem1
            // 
            this.lastNameToolStripMenuItem1.Name = "lastNameToolStripMenuItem1";
            this.lastNameToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.lastNameToolStripMenuItem1.Text = "Last Name";
            this.lastNameToolStripMenuItem1.Click += new System.EventHandler(this.lastNameToolStripMenuItem1_Click);
            // 
            // phoneNumberToolStripMenuItem1
            // 
            this.phoneNumberToolStripMenuItem1.Name = "phoneNumberToolStripMenuItem1";
            this.phoneNumberToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.phoneNumberToolStripMenuItem1.Text = "Phone Number";
            this.phoneNumberToolStripMenuItem1.Click += new System.EventHandler(this.phoneNumberToolStripMenuItem1_Click);
            // 
            // emailAddressToolStripMenuItem1
            // 
            this.emailAddressToolStripMenuItem1.Name = "emailAddressToolStripMenuItem1";
            this.emailAddressToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.emailAddressToolStripMenuItem1.Text = "Email Address";
            this.emailAddressToolStripMenuItem1.Click += new System.EventHandler(this.emailAddressToolStripMenuItem1_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.outputTextBox.Location = new System.Drawing.Point(6, 19);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(271, 180);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.WordWrap = false;
            // 
            // groupSelector
            // 
            this.groupSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupSelector.FormattingEnabled = true;
            this.groupSelector.Location = new System.Drawing.Point(6, 19);
            this.groupSelector.Name = "groupSelector";
            this.groupSelector.Size = new System.Drawing.Size(256, 21);
            this.groupSelector.Sorted = true;
            this.groupSelector.TabIndex = 1;
            this.groupSelector.SelectedIndexChanged += new System.EventHandler(this.GroupSelectorSelectedIndexChanged);
            // 
            // selectedContacts
            // 
            this.selectedContacts.BackColor = System.Drawing.SystemColors.Menu;
            this.selectedContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedContacts.CheckOnClick = true;
            this.selectedContacts.FormattingEnabled = true;
            this.selectedContacts.Items.AddRange(new object[] {
            "Logging in..."});
            this.selectedContacts.Location = new System.Drawing.Point(6, 46);
            this.selectedContacts.Name = "selectedContacts";
            this.selectedContacts.Size = new System.Drawing.Size(256, 242);
            this.selectedContacts.TabIndex = 2;
            this.selectedContacts.SelectedIndexChanged += new System.EventHandler(this.SelectedContactsSelectedIndexChanged);
            // 
            // selectAll
            // 
            this.selectAll.AutoSize = true;
            this.selectAll.Location = new System.Drawing.Point(6, 294);
            this.selectAll.Name = "selectAll";
            this.selectAll.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.selectAll.Size = new System.Drawing.Size(71, 17);
            this.selectAll.TabIndex = 3;
            this.selectAll.Text = "Select All";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.CheckedChanged += new System.EventHandler(this.SelectAllCheckBox);
            // 
            // delayLabel
            // 
            this.delayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(292, 246);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(37, 13);
            this.delayLabel.TabIndex = 13;
            this.delayLabel.Text = "Delay:";
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(222, 182);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendTip.SetToolTip(this.sendButton, "Hold the CTRL key while clicking to send messages from the background.");
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(141, 182);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // savedMessagesBox
            // 
            this.savedMessagesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedMessagesBox.ContextMenuStrip = this.savedMessagesContextMenu;
            this.savedMessagesBox.Enabled = false;
            this.savedMessagesBox.FormattingEnabled = true;
            this.savedMessagesBox.Location = new System.Drawing.Point(303, 19);
            this.savedMessagesBox.Name = "savedMessagesBox";
            this.savedMessagesBox.Size = new System.Drawing.Size(277, 186);
            this.savedMessagesBox.TabIndex = 16;
            this.savedMessagesBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.savedMessagesBox_KeyDown);
            this.savedMessagesBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.savedMessagesBox_DoubleClick);
            this.savedMessagesBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.savedMessagesBox_MouseDown);
            // 
            // savedMessagesContextMenu
            // 
            this.savedMessagesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.savedMessagesContextMenu.Name = "savedMessagesContextMenu";
            this.savedMessagesContextMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // useToolStripMenuItem
            // 
            this.useToolStripMenuItem.Name = "useToolStripMenuItem";
            this.useToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.useToolStripMenuItem.Text = "Use";
            this.useToolStripMenuItem.Click += new System.EventHandler(this.useToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // charsRemaining
            // 
            this.charsRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.charsRemaining.AutoSize = true;
            this.charsRemaining.Location = new System.Drawing.Point(6, 187);
            this.charsRemaining.Name = "charsRemaining";
            this.charsRemaining.Size = new System.Drawing.Size(106, 13);
            this.charsRemaining.TabIndex = 5;
            this.charsRemaining.Text = "480 | Message 1 of 3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputTextBox);
            this.groupBox1.Location = new System.Drawing.Point(589, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 206);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.savedMessagesBox);
            this.groupBox2.Controls.Add(this.textMessageInputBox);
            this.groupBox2.Controls.Add(this.charsRemaining);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.sendButton);
            this.groupBox2.Location = new System.Drawing.Point(286, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 211);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupSelector);
            this.groupBox3.Controls.Add(this.selectedContacts);
            this.groupBox3.Controls.Add(this.selectAll);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 314);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 295);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // contactInfoLabel
            // 
            this.contactInfoLabel.AutoSize = true;
            this.contactInfoLabel.Location = new System.Drawing.Point(12, 16);
            this.contactInfoLabel.Name = "contactInfoLabel";
            this.contactInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.contactInfoLabel.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.contactInfoLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 103);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Info";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SmashText Pro";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // sendTip
            // 
            this.sendTip.ToolTipTitle = "Send From Background";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "SmashText_Log.txt";
            this.saveFileDialog1.Filter = "Text File (*.txt) |*.txt";
            this.saveFileDialog1.InitialDirectory = "%userprofile%\\Documents";
            // 
            // MainUI
            // 
            this.AcceptButton = this.sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmashText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_Closing);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBox)).EndInit();
            this.messageContextMenu.ResumeLayout(false);
            this.savedMessagesContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Timer loginWindowTimer;
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip delayTip;
        private System.Windows.Forms.ToolTip messageTip;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ComboBox groupSelector;
        private System.Windows.Forms.CheckedListBox selectedContacts;
        private System.Windows.Forms.NumericUpDown delayBox;
        private System.Windows.Forms.TextBox textMessageInputBox;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.CheckBox selectAll;
        private System.Windows.Forms.Label charsRemaining;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox savedMessagesBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label contactInfoLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip sendTip;
        private System.Windows.Forms.ContextMenuStrip messageContextMenu;
        private System.Windows.Forms.ContextMenuStrip savedMessagesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emailAddressToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundSendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
	}
}

