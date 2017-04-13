namespace Help_Desk_Tool
{
    partial class optionsPage
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
            this.hostnamePrefixListBox = new System.Windows.Forms.ListBox();
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.onEnterKeyRadioButton_RDP = new System.Windows.Forms.RadioButton();
            this.onEnterKeyRadioButton_PublicDesktop = new System.Windows.Forms.RadioButton();
            this.onEnterKeyRadioButton_RemoteAssist = new System.Windows.Forms.RadioButton();
            this.onEnterKeyRadioButton_cDollar = new System.Windows.Forms.RadioButton();
            this.onEnterKeyRadioButton_InformationPanel = new System.Windows.Forms.RadioButton();
            this.cbLengthUnlimRadioButton = new System.Windows.Forms.RadioButton();
            this.cbLength30RadioButton = new System.Windows.Forms.RadioButton();
            this.cbLength20RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostnamePrefixListBox
            // 
            this.hostnamePrefixListBox.FormattingEnabled = true;
            this.hostnamePrefixListBox.Location = new System.Drawing.Point(6, 120);
            this.hostnamePrefixListBox.Name = "hostnamePrefixListBox";
            this.hostnamePrefixListBox.Size = new System.Drawing.Size(169, 108);
            this.hostnamePrefixListBox.TabIndex = 0;
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Location = new System.Drawing.Point(6, 236);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(169, 20);
            this.hostnameTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(181, 234);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(305, 95);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Add your Prefixes here.\n\nThe Clipboard Integration Feature will refer to this lis" +
    "t when it checks your clipboard. Only enter what the target Hostnames or IPs wil" +
    "l have in common.";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(181, 120);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hostnameTextBox);
            this.groupBox1.Controls.Add(this.hostnamePrefixListBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Location = new System.Drawing.Point(187, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 266);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prefix Configuration";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 72);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shortcuts";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbLengthUnlimRadioButton);
            this.groupBox3.Controls.Add(this.cbLength30RadioButton);
            this.groupBox3.Controls.Add(this.cbLength20RadioButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 45);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Max Clipboard Length:";
            // 
            // onEnterKeyRadioButton_RDP
            // 
            this.onEnterKeyRadioButton_RDP.AutoSize = true;
            this.onEnterKeyRadioButton_RDP.Location = new System.Drawing.Point(6, 65);
            this.onEnterKeyRadioButton_RDP.Name = "onEnterKeyRadioButton_RDP";
            this.onEnterKeyRadioButton_RDP.Size = new System.Drawing.Size(105, 17);
            this.onEnterKeyRadioButton_RDP.TabIndex = 9;
            this.onEnterKeyRadioButton_RDP.TabStop = true;
            this.onEnterKeyRadioButton_RDP.Text = "Remote Desktop";
            this.onEnterKeyRadioButton_RDP.UseVisualStyleBackColor = true;
            // 
            // onEnterKeyRadioButton_PublicDesktop
            // 
            this.onEnterKeyRadioButton_PublicDesktop.AutoSize = true;
            this.onEnterKeyRadioButton_PublicDesktop.Location = new System.Drawing.Point(6, 111);
            this.onEnterKeyRadioButton_PublicDesktop.Name = "onEnterKeyRadioButton_PublicDesktop";
            this.onEnterKeyRadioButton_PublicDesktop.Size = new System.Drawing.Size(109, 17);
            this.onEnterKeyRadioButton_PublicDesktop.TabIndex = 8;
            this.onEnterKeyRadioButton_PublicDesktop.TabStop = true;
            this.onEnterKeyRadioButton_PublicDesktop.Text = "UNC to c$\\Public";
            this.onEnterKeyRadioButton_PublicDesktop.UseVisualStyleBackColor = true;
            // 
            // onEnterKeyRadioButton_RemoteAssist
            // 
            this.onEnterKeyRadioButton_RemoteAssist.AutoSize = true;
            this.onEnterKeyRadioButton_RemoteAssist.Location = new System.Drawing.Point(6, 42);
            this.onEnterKeyRadioButton_RemoteAssist.Name = "onEnterKeyRadioButton_RemoteAssist";
            this.onEnterKeyRadioButton_RemoteAssist.Size = new System.Drawing.Size(116, 17);
            this.onEnterKeyRadioButton_RemoteAssist.TabIndex = 7;
            this.onEnterKeyRadioButton_RemoteAssist.TabStop = true;
            this.onEnterKeyRadioButton_RemoteAssist.Text = "Remote Assistance";
            this.onEnterKeyRadioButton_RemoteAssist.UseVisualStyleBackColor = true;
            // 
            // onEnterKeyRadioButton_cDollar
            // 
            this.onEnterKeyRadioButton_cDollar.AutoSize = true;
            this.onEnterKeyRadioButton_cDollar.Location = new System.Drawing.Point(6, 88);
            this.onEnterKeyRadioButton_cDollar.Name = "onEnterKeyRadioButton_cDollar";
            this.onEnterKeyRadioButton_cDollar.Size = new System.Drawing.Size(75, 17);
            this.onEnterKeyRadioButton_cDollar.TabIndex = 6;
            this.onEnterKeyRadioButton_cDollar.TabStop = true;
            this.onEnterKeyRadioButton_cDollar.Text = "UNC to c$";
            this.onEnterKeyRadioButton_cDollar.UseVisualStyleBackColor = true;
            // 
            // onEnterKeyRadioButton_InformationPanel
            // 
            this.onEnterKeyRadioButton_InformationPanel.AutoSize = true;
            this.onEnterKeyRadioButton_InformationPanel.Location = new System.Drawing.Point(6, 19);
            this.onEnterKeyRadioButton_InformationPanel.Name = "onEnterKeyRadioButton_InformationPanel";
            this.onEnterKeyRadioButton_InformationPanel.Size = new System.Drawing.Size(148, 17);
            this.onEnterKeyRadioButton_InformationPanel.TabIndex = 5;
            this.onEnterKeyRadioButton_InformationPanel.TabStop = true;
            this.onEnterKeyRadioButton_InformationPanel.Text = "Information Panel (default)";
            this.onEnterKeyRadioButton_InformationPanel.UseVisualStyleBackColor = true;
            // 
            // cbLengthUnlimRadioButton
            // 
            this.cbLengthUnlimRadioButton.AutoSize = true;
            this.cbLengthUnlimRadioButton.Location = new System.Drawing.Point(92, 21);
            this.cbLengthUnlimRadioButton.Name = "cbLengthUnlimRadioButton";
            this.cbLengthUnlimRadioButton.Size = new System.Drawing.Size(68, 17);
            this.cbLengthUnlimRadioButton.TabIndex = 3;
            this.cbLengthUnlimRadioButton.TabStop = true;
            this.cbLengthUnlimRadioButton.Text = "Unlimited";
            this.cbLengthUnlimRadioButton.UseVisualStyleBackColor = true;
            // 
            // cbLength30RadioButton
            // 
            this.cbLength30RadioButton.AutoSize = true;
            this.cbLength30RadioButton.Location = new System.Drawing.Point(49, 21);
            this.cbLength30RadioButton.Name = "cbLength30RadioButton";
            this.cbLength30RadioButton.Size = new System.Drawing.Size(37, 17);
            this.cbLength30RadioButton.TabIndex = 2;
            this.cbLength30RadioButton.TabStop = true;
            this.cbLength30RadioButton.Text = "30";
            this.cbLength30RadioButton.UseVisualStyleBackColor = true;
            // 
            // cbLength20RadioButton
            // 
            this.cbLength20RadioButton.AutoSize = true;
            this.cbLength20RadioButton.Location = new System.Drawing.Point(6, 21);
            this.cbLength20RadioButton.Name = "cbLength20RadioButton";
            this.cbLength20RadioButton.Size = new System.Drawing.Size(37, 17);
            this.cbLength20RadioButton.TabIndex = 1;
            this.cbLength20RadioButton.TabStop = true;
            this.cbLength20RadioButton.Text = "20";
            this.cbLength20RadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.onEnterKeyRadioButton_RDP);
            this.groupBox4.Controls.Add(this.onEnterKeyRadioButton_InformationPanel);
            this.groupBox4.Controls.Add(this.onEnterKeyRadioButton_PublicDesktop);
            this.groupBox4.Controls.Add(this.onEnterKeyRadioButton_cDollar);
            this.groupBox4.Controls.Add(this.onEnterKeyRadioButton_RemoteAssist);
            this.groupBox4.Location = new System.Drawing.Point(12, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 138);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "On enter key action:";
            // 
            // optionsPage
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 285);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "optionsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.configureHostnamesForm_FormClosing);
            this.Load += new System.EventHandler(this.configureHostnamesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox hostnamePrefixListBox;
        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton cbLengthUnlimRadioButton;
        private System.Windows.Forms.RadioButton cbLength30RadioButton;
        private System.Windows.Forms.RadioButton cbLength20RadioButton;
        private System.Windows.Forms.RadioButton onEnterKeyRadioButton_cDollar;
        private System.Windows.Forms.RadioButton onEnterKeyRadioButton_InformationPanel;
        private System.Windows.Forms.RadioButton onEnterKeyRadioButton_RDP;
        private System.Windows.Forms.RadioButton onEnterKeyRadioButton_PublicDesktop;
        private System.Windows.Forms.RadioButton onEnterKeyRadioButton_RemoteAssist;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}