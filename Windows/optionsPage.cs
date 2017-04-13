using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Desk_Tool
{
    public partial class optionsPage : Form
    {
        public optionsPage()
        {
            InitializeComponent();

            int setCBLengthRadioButton = Properties.Settings.Default.options_MaxHostnameLength;
            switch (setCBLengthRadioButton)
            {
                case 20:
                    cbLength20RadioButton.Checked = true;
                    break;
                case 30:
                    cbLength30RadioButton.Checked = true;
                    break;
                case 999:
                    cbLengthUnlimRadioButton.Checked = true;
                    break;
            }

            int onEnterKeyAction = Properties.Settings.Default.options_OnEnterKeyAction;
            switch(onEnterKeyAction)
            {
                case 0: //  Information Panel (wmi)
                    onEnterKeyRadioButton_InformationPanel.Checked = true;
                    break;
                case 1: //  Remote assist
                    onEnterKeyRadioButton_RemoteAssist.Checked = true;
                    break;
                case 2: //  Remote desktop
                    onEnterKeyRadioButton_RDP.Checked = true;
                    break;
                case 3: //  c$
                    onEnterKeyRadioButton_cDollar.Checked = true;
                    break;
                case 4: //  c$/public/desktop
                    onEnterKeyRadioButton_PublicDesktop.Checked = true;
                    break;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            hostnamePrefixListBox.Items.Add(hostnameTextBox.Text);
            hostnameTextBox.Clear();
            hostnameTextBox.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hostnamePrefixListBox.Items.Clear();
        }

        private void configureHostnamesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var newList = new ArrayList();
            foreach (object item in hostnamePrefixListBox.Items)
            {
                newList.Add(item);
            }

            Properties.Settings.Default._hostnamePrefixes = newList;
            Properties.Settings.Default.Save();

            if (cbLength20RadioButton.Checked) { Properties.Settings.Default.options_MaxHostnameLength = 20; }
            if (cbLength30RadioButton.Checked) { Properties.Settings.Default.options_MaxHostnameLength = 30; }
            if (cbLengthUnlimRadioButton.Checked) { Properties.Settings.Default.options_MaxHostnameLength = 999; }

            if (onEnterKeyRadioButton_InformationPanel.Checked) { Properties.Settings.Default.options_OnEnterKeyAction = 0; }
            if (onEnterKeyRadioButton_RemoteAssist.Checked) { Properties.Settings.Default.options_OnEnterKeyAction = 1; }
            if (onEnterKeyRadioButton_RDP.Checked) { Properties.Settings.Default.options_OnEnterKeyAction = 2; }
            if (onEnterKeyRadioButton_cDollar.Checked) { Properties.Settings.Default.options_OnEnterKeyAction = 3; }
            if (onEnterKeyRadioButton_PublicDesktop.Checked) { Properties.Settings.Default.options_OnEnterKeyAction = 4; }

            Form mainForm = new mainForm();
            mainForm.Show();
        }

        private void configureHostnamesForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default._hostnamePrefixes != null)
            {
                var readList = new ArrayList();
                foreach (object item in Properties.Settings.Default._hostnamePrefixes)
                {
                    hostnamePrefixListBox.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
        }
    }
}
