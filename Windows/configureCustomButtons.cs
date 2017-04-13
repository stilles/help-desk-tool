using System;
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
    public partial class configureCustomButtons : Form
    {
        public configureCustomButtons(string _button)
        {
            InitializeComponent();

            buttonToBeConfigured.Text = _button;
            switch (buttonToBeConfigured.Text) {
                case "button1":
                    customButtonName.Text = Properties.Settings.Default._customButton1_name;
                    customButtonPath.Text = Properties.Settings.Default._customButton1_path;
                    break;
                case "button2":
                    customButtonName.Text = Properties.Settings.Default._customButton2_name;
                    customButtonPath.Text = Properties.Settings.Default._customButton2_path;
                    break;
                case "button3":
                    customButtonName.Text = Properties.Settings.Default._customButton3_name;
                    customButtonPath.Text = Properties.Settings.Default._customButton3_path;
                    break;
                case "button4":
                    customButtonName.Text = Properties.Settings.Default._customButton4_name;
                    customButtonPath.Text = Properties.Settings.Default._customButton4_path;
                    break;
                case "button5":
                    customButtonName.Text = Properties.Settings.Default._customButton5_name;
                    customButtonPath.Text = Properties.Settings.Default._customButton5_path;
                    break;
                case "button6":
                    customButtonName.Text = Properties.Settings.Default._customButton6_name;
                    customButtonPath.Text = Properties.Settings.Default._customButton6_path;
                    break;
            }
        }

        private void customButtonSet_Click(object sender, EventArgs e)
        {
            switch (buttonToBeConfigured.Text)
            {
                case "button1":
                    Properties.Settings.Default._customButton1_name = customButtonName.Text;
                    Properties.Settings.Default._customButton1_path = @customButtonPath.Text;
                    break;
                case "button2":
                    Properties.Settings.Default._customButton2_name = customButtonName.Text;
                    Properties.Settings.Default._customButton2_path = @customButtonPath.Text;
                    break;
                case "button3":
                    Properties.Settings.Default._customButton3_name = customButtonName.Text;
                    Properties.Settings.Default._customButton3_path = @customButtonPath.Text;
                    break;
                case "button4":
                    Properties.Settings.Default._customButton4_name = customButtonName.Text;
                    Properties.Settings.Default._customButton4_path = @customButtonPath.Text;
                    break;
                case "button5":
                    Properties.Settings.Default._customButton5_name = customButtonName.Text;
                    Properties.Settings.Default._customButton5_path = @customButtonPath.Text;
                    break;
                case "button6":
                    Properties.Settings.Default._customButton6_name = customButtonName.Text;
                    Properties.Settings.Default._customButton6_path = @customButtonPath.Text;
                    break;
            }
            this.Close();
        }

        private void configureCustomButtons_Load(object sender, EventArgs e)
        {

        }

        private void configureCustomButtons_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }
    }
}
