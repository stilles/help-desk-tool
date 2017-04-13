namespace Help_Desk_Tool
{
    partial class configureCustomButtons
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
            this.customButtonPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customButtonSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customButtonName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonToBeConfigured = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customButtonPath
            // 
            this.customButtonPath.Location = new System.Drawing.Point(73, 69);
            this.customButtonPath.Name = "customButtonPath";
            this.customButtonPath.Size = new System.Drawing.Size(253, 20);
            this.customButtonPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // customButtonSet
            // 
            this.customButtonSet.Location = new System.Drawing.Point(143, 96);
            this.customButtonSet.Name = "customButtonSet";
            this.customButtonSet.Size = new System.Drawing.Size(75, 23);
            this.customButtonSet.TabIndex = 2;
            this.customButtonSet.Text = "Set";
            this.customButtonSet.UseVisualStyleBackColor = true;
            this.customButtonSet.Click += new System.EventHandler(this.customButtonSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // customButtonName
            // 
            this.customButtonName.Location = new System.Drawing.Point(73, 43);
            this.customButtonName.Name = "customButtonName";
            this.customButtonName.Size = new System.Drawing.Size(253, 20);
            this.customButtonName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Configuring:";
            // 
            // buttonToBeConfigured
            // 
            this.buttonToBeConfigured.AutoSize = true;
            this.buttonToBeConfigured.Location = new System.Drawing.Point(208, 9);
            this.buttonToBeConfigured.Name = "buttonToBeConfigured";
            this.buttonToBeConfigured.Size = new System.Drawing.Size(13, 13);
            this.buttonToBeConfigured.TabIndex = 6;
            this.buttonToBeConfigured.Text = "?";
            // 
            // configureCustomButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 128);
            this.Controls.Add(this.buttonToBeConfigured);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customButtonName);
            this.Controls.Add(this.customButtonSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customButtonPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "configureCustomButtons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Button";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.configureCustomButtons_FormClosed);
            this.Load += new System.EventHandler(this.configureCustomButtons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customButtonPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customButtonSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customButtonName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label buttonToBeConfigured;
    }
}