namespace Help_Desk_Tool
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wmiConnectButton = new System.Windows.Forms.Button();
            this.targetSystemUptimeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.targetStatusLabel = new System.Windows.Forms.Label();
            this.targetCPUNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.targetRAMLabel = new System.Windows.Forms.Label();
            this.targetLoggedOnUserLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.targetHostnameLabel = new System.Windows.Forms.Label();
            this.targetModelLabel = new System.Windows.Forms.Label();
            this.targetManufacturerLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actionProgressBar = new System.Windows.Forms.ProgressBar();
            this.assistButton = new System.Windows.Forms.Button();
            this.rdpButton = new System.Windows.Forms.Button();
            this.cdollarButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearClipBoardButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardIntegrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRemoteProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootTargetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pcManagementButton = new System.Windows.Forms.Button();
            this.eventvwrButton = new System.Windows.Forms.Button();
            this.cDollarPublicDesktopButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customShortcutButton6 = new System.Windows.Forms.Button();
            this.customShortcutButton5 = new System.Windows.Forms.Button();
            this.customShortcutButton4 = new System.Windows.Forms.Button();
            this.customShortcutButton3 = new System.Windows.Forms.Button();
            this.customShortcutButton2 = new System.Windows.Forms.Button();
            this.customShortcutButton1 = new System.Windows.Forms.Button();
            this.targetHostnameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Location = new System.Drawing.Point(4, 33);
            this.hostnameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(111, 20);
            this.hostnameTextBox.TabIndex = 0;
            this.hostnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hostnameTextBox_KeyDown);
            this.hostnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hostnameTextBox_KeyPress_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wmiConnectButton);
            this.groupBox1.Controls.Add(this.targetSystemUptimeLabel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.targetStatusLabel);
            this.groupBox1.Controls.Add(this.targetCPUNameLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.targetRAMLabel);
            this.groupBox1.Controls.Add(this.targetLoggedOnUserLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.targetHostnameLabel);
            this.groupBox1.Controls.Add(this.targetModelLabel);
            this.groupBox1.Controls.Add(this.targetManufacturerLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 211);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(329, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // wmiConnectButton
            // 
            this.wmiConnectButton.BackgroundImage = global::Help_Desk_Tool.Properties.Resources.imageres_0139;
            this.wmiConnectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wmiConnectButton.Location = new System.Drawing.Point(299, 10);
            this.wmiConnectButton.Name = "wmiConnectButton";
            this.wmiConnectButton.Size = new System.Drawing.Size(25, 25);
            this.wmiConnectButton.TabIndex = 18;
            this.wmiConnectButton.UseVisualStyleBackColor = true;
            this.wmiConnectButton.Click += new System.EventHandler(this.wmiConnectButton_Click);
            // 
            // targetSystemUptimeLabel
            // 
            this.targetSystemUptimeLabel.AutoSize = true;
            this.targetSystemUptimeLabel.Location = new System.Drawing.Point(86, 29);
            this.targetSystemUptimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetSystemUptimeLabel.Name = "targetSystemUptimeLabel";
            this.targetSystemUptimeLabel.Size = new System.Drawing.Size(10, 13);
            this.targetSystemUptimeLabel.TabIndex = 16;
            this.targetSystemUptimeLabel.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Uptime:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(230, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "v1.0, Apr 12, 2017";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // targetStatusLabel
            // 
            this.targetStatusLabel.AutoSize = true;
            this.targetStatusLabel.Location = new System.Drawing.Point(86, 16);
            this.targetStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetStatusLabel.Name = "targetStatusLabel";
            this.targetStatusLabel.Size = new System.Drawing.Size(10, 13);
            this.targetStatusLabel.TabIndex = 14;
            this.targetStatusLabel.Text = ".";
            // 
            // targetCPUNameLabel
            // 
            this.targetCPUNameLabel.AutoSize = true;
            this.targetCPUNameLabel.Location = new System.Drawing.Point(84, 140);
            this.targetCPUNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetCPUNameLabel.Name = "targetCPUNameLabel";
            this.targetCPUNameLabel.Size = new System.Drawing.Size(10, 13);
            this.targetCPUNameLabel.TabIndex = 12;
            this.targetCPUNameLabel.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Status:";
            // 
            // targetRAMLabel
            // 
            this.targetRAMLabel.AutoSize = true;
            this.targetRAMLabel.Location = new System.Drawing.Point(84, 153);
            this.targetRAMLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetRAMLabel.Name = "targetRAMLabel";
            this.targetRAMLabel.Size = new System.Drawing.Size(10, 13);
            this.targetRAMLabel.TabIndex = 11;
            this.targetRAMLabel.Text = ".";
            // 
            // targetLoggedOnUserLabel
            // 
            this.targetLoggedOnUserLabel.AutoSize = true;
            this.targetLoggedOnUserLabel.Location = new System.Drawing.Point(86, 69);
            this.targetLoggedOnUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetLoggedOnUserLabel.Name = "targetLoggedOnUserLabel";
            this.targetLoggedOnUserLabel.Size = new System.Drawing.Size(10, 13);
            this.targetLoggedOnUserLabel.TabIndex = 10;
            this.targetLoggedOnUserLabel.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "User:";
            // 
            // targetHostnameLabel
            // 
            this.targetHostnameLabel.AutoSize = true;
            this.targetHostnameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.targetHostnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetHostnameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.targetHostnameLabel.Location = new System.Drawing.Point(86, 56);
            this.targetHostnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetHostnameLabel.Name = "targetHostnameLabel";
            this.targetHostnameLabel.Size = new System.Drawing.Size(11, 13);
            this.targetHostnameLabel.TabIndex = 8;
            this.targetHostnameLabel.Text = ".";
            this.targetHostnameLabel.Click += new System.EventHandler(this.targetHostnameLabel_Click);
            // 
            // targetModelLabel
            // 
            this.targetModelLabel.AutoSize = true;
            this.targetModelLabel.Location = new System.Drawing.Point(86, 110);
            this.targetModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetModelLabel.Name = "targetModelLabel";
            this.targetModelLabel.Size = new System.Drawing.Size(10, 13);
            this.targetModelLabel.TabIndex = 7;
            this.targetModelLabel.Text = ".";
            // 
            // targetManufacturerLabel
            // 
            this.targetManufacturerLabel.AutoSize = true;
            this.targetManufacturerLabel.Location = new System.Drawing.Point(86, 97);
            this.targetManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetManufacturerLabel.Name = "targetManufacturerLabel";
            this.targetManufacturerLabel.Size = new System.Drawing.Size(10, 13);
            this.targetManufacturerLabel.TabIndex = 6;
            this.targetManufacturerLabel.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "RAM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "CPU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hostname:";
            // 
            // actionProgressBar
            // 
            this.actionProgressBar.Location = new System.Drawing.Point(4, 18);
            this.actionProgressBar.Name = "actionProgressBar";
            this.actionProgressBar.Size = new System.Drawing.Size(169, 48);
            this.actionProgressBar.TabIndex = 1;
            // 
            // assistButton
            // 
            this.assistButton.Location = new System.Drawing.Point(62, 18);
            this.assistButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.assistButton.Name = "assistButton";
            this.assistButton.Size = new System.Drawing.Size(54, 23);
            this.assistButton.TabIndex = 3;
            this.assistButton.Text = "Assist";
            this.assistButton.UseVisualStyleBackColor = true;
            this.assistButton.Click += new System.EventHandler(this.assistButton_Click);
            // 
            // rdpButton
            // 
            this.rdpButton.Location = new System.Drawing.Point(120, 18);
            this.rdpButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdpButton.Name = "rdpButton";
            this.rdpButton.Size = new System.Drawing.Size(54, 23);
            this.rdpButton.TabIndex = 4;
            this.rdpButton.Text = "RDP";
            this.rdpButton.UseVisualStyleBackColor = true;
            this.rdpButton.Click += new System.EventHandler(this.rdpButton_Click);
            // 
            // cdollarButton
            // 
            this.cdollarButton.Location = new System.Drawing.Point(4, 18);
            this.cdollarButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cdollarButton.Name = "cdollarButton";
            this.cdollarButton.Size = new System.Drawing.Size(54, 23);
            this.cdollarButton.TabIndex = 5;
            this.cdollarButton.Text = "c$";
            this.cdollarButton.UseVisualStyleBackColor = true;
            this.cdollarButton.Click += new System.EventHandler(this.cdollarButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearClipBoardButton);
            this.groupBox2.Controls.Add(this.hostnameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(145, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target";
            // 
            // clearClipBoardButton
            // 
            this.clearClipBoardButton.BackgroundImage = global::Help_Desk_Tool.Properties.Resources.imageres_0206;
            this.clearClipBoardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearClipBoardButton.Location = new System.Drawing.Point(115, 30);
            this.clearClipBoardButton.Name = "clearClipBoardButton";
            this.clearClipBoardButton.Size = new System.Drawing.Size(25, 25);
            this.clearClipBoardButton.TabIndex = 17;
            this.clearClipBoardButton.TabStop = false;
            this.clearClipBoardButton.UseVisualStyleBackColor = true;
            this.clearClipBoardButton.Click += new System.EventHandler(this.clearClipBoardButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clipboardIntegrationToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.configureToolStripMenuItem.Text = "Options";
            // 
            // clipboardIntegrationToolStripMenuItem
            // 
            this.clipboardIntegrationToolStripMenuItem.Checked = true;
            this.clipboardIntegrationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clipboardIntegrationToolStripMenuItem.Name = "clipboardIntegrationToolStripMenuItem";
            this.clipboardIntegrationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.clipboardIntegrationToolStripMenuItem.Text = "Auto-Paste Clipboard";
            this.clipboardIntegrationToolStripMenuItem.ToolTipText = "Automatically copies the clipboard contents into the Target field upon opening th" +
    "e application.";
            this.clipboardIntegrationToolStripMenuItem.Click += new System.EventHandler(this.clipboardIntegrationToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.optionsToolStripMenuItem.Text = "Config";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listRemoteProcessesToolStripMenuItem,
            this.rebootTargetToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // listRemoteProcessesToolStripMenuItem
            // 
            this.listRemoteProcessesToolStripMenuItem.Name = "listRemoteProcessesToolStripMenuItem";
            this.listRemoteProcessesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.listRemoteProcessesToolStripMenuItem.Text = "Process List";
            this.listRemoteProcessesToolStripMenuItem.Click += new System.EventHandler(this.listRemoteProcessesToolStripMenuItem_Click);
            // 
            // rebootTargetToolStripMenuItem
            // 
            this.rebootTargetToolStripMenuItem.Name = "rebootTargetToolStripMenuItem";
            this.rebootTargetToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.rebootTargetToolStripMenuItem.Text = "Reboot Target";
            this.rebootTargetToolStripMenuItem.Click += new System.EventHandler(this.rebootTargetToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.actionProgressBar);
            this.groupBox4.Controls.Add(this.pcManagementButton);
            this.groupBox4.Controls.Add(this.eventvwrButton);
            this.groupBox4.Controls.Add(this.cDollarPublicDesktopButton);
            this.groupBox4.Controls.Add(this.cdollarButton);
            this.groupBox4.Controls.Add(this.assistButton);
            this.groupBox4.Controls.Add(this.rdpButton);
            this.groupBox4.Location = new System.Drawing.Point(157, 25);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(180, 79);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // pcManagementButton
            // 
            this.pcManagementButton.Location = new System.Drawing.Point(62, 43);
            this.pcManagementButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pcManagementButton.Name = "pcManagementButton";
            this.pcManagementButton.Size = new System.Drawing.Size(54, 23);
            this.pcManagementButton.TabIndex = 8;
            this.pcManagementButton.Text = "Manage";
            this.pcManagementButton.UseVisualStyleBackColor = true;
            this.pcManagementButton.Click += new System.EventHandler(this.pcManagementButton_Click);
            // 
            // eventvwrButton
            // 
            this.eventvwrButton.Location = new System.Drawing.Point(120, 43);
            this.eventvwrButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.eventvwrButton.Name = "eventvwrButton";
            this.eventvwrButton.Size = new System.Drawing.Size(54, 23);
            this.eventvwrButton.TabIndex = 7;
            this.eventvwrButton.Text = "EvLog";
            this.eventvwrButton.UseVisualStyleBackColor = true;
            this.eventvwrButton.Click += new System.EventHandler(this.eventvwrButton_Click);
            // 
            // cDollarPublicDesktopButton
            // 
            this.cDollarPublicDesktopButton.Location = new System.Drawing.Point(4, 43);
            this.cDollarPublicDesktopButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cDollarPublicDesktopButton.Name = "cDollarPublicDesktopButton";
            this.cDollarPublicDesktopButton.Size = new System.Drawing.Size(54, 23);
            this.cDollarPublicDesktopButton.TabIndex = 6;
            this.cDollarPublicDesktopButton.Text = "Public";
            this.cDollarPublicDesktopButton.UseVisualStyleBackColor = true;
            this.cDollarPublicDesktopButton.Click += new System.EventHandler(this.cDollarPublicDesktopButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.customShortcutButton6);
            this.groupBox3.Controls.Add(this.customShortcutButton5);
            this.groupBox3.Controls.Add(this.customShortcutButton4);
            this.groupBox3.Controls.Add(this.customShortcutButton3);
            this.groupBox3.Controls.Add(this.customShortcutButton2);
            this.groupBox3.Controls.Add(this.customShortcutButton1);
            this.groupBox3.Location = new System.Drawing.Point(8, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 96);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Shortcuts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Right-click to configure shortcuts.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // customShortcutButton6
            // 
            this.customShortcutButton6.Location = new System.Drawing.Point(216, 47);
            this.customShortcutButton6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customShortcutButton6.Name = "customShortcutButton6";
            this.customShortcutButton6.Size = new System.Drawing.Size(93, 23);
            this.customShortcutButton6.TabIndex = 13;
            this.customShortcutButton6.Text = "6";
            this.customShortcutButton6.UseVisualStyleBackColor = true;
            this.customShortcutButton6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cutomShortcutButton6_MouseDown);
            // 
            // customShortcutButton5
            // 
            this.customShortcutButton5.Location = new System.Drawing.Point(119, 47);
            this.customShortcutButton5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customShortcutButton5.Name = "customShortcutButton5";
            this.customShortcutButton5.Size = new System.Drawing.Size(93, 23);
            this.customShortcutButton5.TabIndex = 12;
            this.customShortcutButton5.Text = "5";
            this.customShortcutButton5.UseVisualStyleBackColor = true;
            this.customShortcutButton5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customShortcutButton5_MouseDown);
            // 
            // customShortcutButton4
            // 
            this.customShortcutButton4.Location = new System.Drawing.Point(22, 47);
            this.customShortcutButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customShortcutButton4.Name = "customShortcutButton4";
            this.customShortcutButton4.Size = new System.Drawing.Size(93, 23);
            this.customShortcutButton4.TabIndex = 11;
            this.customShortcutButton4.Text = "4";
            this.customShortcutButton4.UseVisualStyleBackColor = true;
            this.customShortcutButton4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customShortcutButton4_MouseDown);
            // 
            // customShortcutButton3
            // 
            this.customShortcutButton3.Location = new System.Drawing.Point(216, 18);
            this.customShortcutButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customShortcutButton3.Name = "customShortcutButton3";
            this.customShortcutButton3.Size = new System.Drawing.Size(93, 23);
            this.customShortcutButton3.TabIndex = 10;
            this.customShortcutButton3.Text = "3";
            this.customShortcutButton3.UseVisualStyleBackColor = true;
            this.customShortcutButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customShortcutButton3_MouseDown);
            // 
            // customShortcutButton2
            // 
            this.customShortcutButton2.Location = new System.Drawing.Point(119, 18);
            this.customShortcutButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customShortcutButton2.Name = "customShortcutButton2";
            this.customShortcutButton2.Size = new System.Drawing.Size(93, 23);
            this.customShortcutButton2.TabIndex = 9;
            this.customShortcutButton2.Text = "2";
            this.customShortcutButton2.UseVisualStyleBackColor = true;
            this.customShortcutButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customShortcutButton2_MouseDown);
            // 
            // customShortcutButton1
            // 
            this.customShortcutButton1.Location = new System.Drawing.Point(22, 18);
            this.customShortcutButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customShortcutButton1.Name = "customShortcutButton1";
            this.customShortcutButton1.Size = new System.Drawing.Size(93, 23);
            this.customShortcutButton1.TabIndex = 8;
            this.customShortcutButton1.Text = "1";
            this.customShortcutButton1.UseVisualStyleBackColor = true;
            this.customShortcutButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customShortcutButton1_MouseDown);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 392);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help Desk Tool";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button assistButton;
        private System.Windows.Forms.Button rdpButton;
        private System.Windows.Forms.Button cdollarButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label targetModelLabel;
        private System.Windows.Forms.Label targetManufacturerLabel;
        private System.Windows.Forms.Label targetHostnameLabel;
        private System.Windows.Forms.Label targetLoggedOnUserLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label targetRAMLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label targetCPUNameLabel;
        private System.Windows.Forms.Label targetStatusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button eventvwrButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button customShortcutButton1;
        private System.Windows.Forms.Button customShortcutButton3;
        private System.Windows.Forms.Button customShortcutButton2;
        private System.Windows.Forms.Button cDollarPublicDesktopButton;
        private System.Windows.Forms.ProgressBar actionProgressBar;
        private System.Windows.Forms.Label targetSystemUptimeLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clipboardIntegrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootTargetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRemoteProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolTip targetHostnameToolTip;
        private System.Windows.Forms.Button pcManagementButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button customShortcutButton6;
        private System.Windows.Forms.Button customShortcutButton5;
        private System.Windows.Forms.Button customShortcutButton4;
        private System.Windows.Forms.Button clearClipBoardButton;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button wmiConnectButton;
    }
}

