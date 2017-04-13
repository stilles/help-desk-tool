using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/*
 *      Title:      Help Desk Tool
 *      Author:     Jeff Reed <socomstilles@gmail.com>
 *      Summary:    Simplifying the Enterprise Help Desk experience by bringing commonly used commands and tools together in a single pane of glass.
 * 
*/
namespace Help_Desk_Tool
{

    public partial class mainForm : Form
    {
        //Initialize the AutoCompleteCollection as application opens.
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

        //Threading setup.
        private BackgroundWorker _BackgroundWorker;
        private Random _Random;

        //Global variables
        private string clipboardPrevious = null;
        private string clipboardCurrent = null;
        private string[] hostnamePrefixesArray = null;
        private int onEnterKeyAction = 0;

        public mainForm()
        {
            InitializeComponent();
            actionProgressBar.Style = ProgressBarStyle.Marquee;
            actionProgressBar.Visible = false;
            _Random = new Random();

            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            _BackgroundWorker = new BackgroundWorker();
            _BackgroundWorker.WorkerReportsProgress = true;

            _BackgroundWorker.DoWork += (sender, e) => ((MethodInvoker)e.Argument).Invoke();
            _BackgroundWorker.ProgressChanged += (sender, e) =>
                {
                    actionProgressBar.Style = ProgressBarStyle.Continuous;
                    actionProgressBar.Value = e.ProgressPercentage;
                };
            _BackgroundWorker.RunWorkerCompleted += (sender, e) =>
                {
                    if (actionProgressBar.Style == ProgressBarStyle.Marquee)
                    {
                        actionProgressBar.Visible = false;
                    }
                };
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            customShortcutButton1.Text = Properties.Settings.Default._customButton1_name;
            customShortcutButton2.Text = Properties.Settings.Default._customButton2_name;
            customShortcutButton3.Text = Properties.Settings.Default._customButton3_name;
            customShortcutButton4.Text = Properties.Settings.Default._customButton4_name;
            customShortcutButton5.Text = Properties.Settings.Default._customButton5_name;
            customShortcutButton6.Text = Properties.Settings.Default._customButton6_name;

            if (Properties.Settings.Default._hostnamePrefixes != null)
            {
                loadValidHostnames();
            }

            //  Load variable
            onEnterKeyAction = Properties.Settings.Default.options_OnEnterKeyAction;
        }

        private void loadValidHostnames()
        {
            if (Properties.Settings.Default._hostnamePrefixes != null)
            {
                List<string> _list = new List<string>();
                //hostnamePrefixesArray = Properties.Settings.Default._hostnamePrefixes.ToString();
                foreach (string s in Properties.Settings.Default._hostnamePrefixes)
                {
                    _list.Add(s);
                }
                hostnamePrefixesArray = _list.ToArray();
            }
        }

        private void cdollarButton_Click(object sender, EventArgs e)
        {
            _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                //  Basic error handling.
                try
                {
                    Process.Start(@"\\" + @hostnameTextBox.Text + @"\c$\");
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to connect to: '" + hostnameTextBox.Text + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    targetStatusLabel.Text = "Unknown";
                }
            }));
        }

        private void cDollarPublicDesktopButton_Click(object sender, EventArgs e)
        {

            _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));

                    //  Basic error handling.
            try
            {
                Process.Start(@"\\" + @hostnameTextBox.Text + @"\c$\Users\Public\Desktop");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to: '" + hostnameTextBox.Text + "'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetStatusLabel.Text = "Unknown";
            }

                }));
        }

        private void assistButton_Click(object sender, EventArgs e)
        {
            _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                        ProcessStartInfo offerRA = new ProcessStartInfo("msra.exe");
                        offerRA.Arguments = "/offerRA " + hostnameTextBox.Text;

                        Process.Start(offerRA);
           }));
        }

        private void rdpButton_Click(object sender, EventArgs e)
        {
            _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                    ProcessStartInfo startRDP = new ProcessStartInfo("mstsc.exe");
                    startRDP.Arguments = "/v:" + hostnameTextBox.Text;

                    Process.Start(startRDP);
                }));
        }

        private void hostnameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //  If 'ENTER' key pressed, run query.
            if (e.KeyValue == 13)
            {
                switch(onEnterKeyAction)
                {
                    case 0:
                        runWmiQueries();
                        break;
                    case 1:
                        assistButton_Click(sender, e);
                        break;
                    case 2:
                        rdpButton_Click(sender, e);
                        break;
                    case 3:
                        cdollarButton_Click(sender, e);
                        break;
                    case 4:
                        cDollarPublicDesktopButton_Click(sender, e);
                        break;
                }
            }
        }

        private void runWmiQueries()
        {
            wmi wmi = new wmi();
            
            //  Add current entry to AutoComplete.
            autoComplete.Add(hostnameTextBox.Text);

            _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
            {
                actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));

                var queryResult = new List<computerInformation>();
                queryResult = wmi.QuerySystemInfo(hostnameTextBox.Text);
                updateFormSysInfo(queryResult);


                var queryResult2 = new List<computerInformation>();
                queryResult2 = wmi.QueryUserInfo(hostnameTextBox.Text);
                updateFormUserInfo(queryResult2);

            }));
        }

        private void updateFormUserInfo(List<computerInformation> _list)
        {
            MethodInvoker inv = delegate
            {
                if (_list.Any())
                {
                    targetLoggedOnUserLabel.Text = _list[0].UserName;

                }
                else
                {
                    targetLoggedOnUserLabel.Text = "";
                }

            };
            this.Invoke(inv);
        }

        private void clearFormSysInfo()
        {
                    targetStatusLabel.Text = "Press 'Enter' to connect.";

                    targetHostnameLabel.Text = "";
                    targetLoggedOnUserLabel.Text = "";

                    targetManufacturerLabel.Text = "";
                    targetModelLabel.Text = "";

                    targetCPUNameLabel.Text = "";
                    targetRAMLabel.Text = "";

                    targetSystemUptimeLabel.Text = "";
        }

        private void updateFormSysInfo(List<computerInformation> _list)
        {
            MethodInvoker inv = delegate
            {
                if (_list.Any())
                {

                    targetStatusLabel.Text = "Online";

                    targetHostnameLabel.Text = _list[0].Name;

                    targetManufacturerLabel.Text = _list[0].Manufacturer;
                    targetModelLabel.Text = _list[0].Model;

                    targetCPUNameLabel.Text = _list[0].CPUName;

                    string totalRAM = (((Convert.ToInt64(_list[0].TotalPhysicalMemory) / 1000) / 1000) / 1000).ToString("N0");
                    targetRAMLabel.Text = totalRAM + " GB";

                    targetSystemUptimeLabel.Text = _list[0].SystemUptime;

                }
                else
                {
                    targetStatusLabel.Text = "Unable to connect!";

                    targetHostnameLabel.Text = "";
                    targetLoggedOnUserLabel.Text = "";

                    targetManufacturerLabel.Text = "";
                    targetModelLabel.Text = "";

                    targetCPUNameLabel.Text = "";
                    targetRAMLabel.Text = "";

                    targetSystemUptimeLabel.Text = "";
                }

            };
            this.Invoke(inv);
        }

        private void hostnameTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //  Do not allow "spaces" in this textbox.
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private bool checkHostnameMatch(string _string, int _maxLength)
        {
            try
            {
                if (hostnamePrefixesArray.Any(_string.ToLowerInvariant().Contains) && _string.Length <= _maxLength)
                {
                    return true;
                }
                else if (hostnamePrefixesArray.Any(_string.ToUpperInvariant().Contains) && _string.Length <= _maxLength)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception) { return false; }
        }

        private void getClipboardContents()
        {
            //Attempt to paste Clipboard data, if we think it's valid.
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text) && clipboardIntegrationToolStripMenuItem.Checked) {
                clipboardCurrent = (String)iData.GetData(DataFormats.Text);
            }
        }

        private void pasteClipboardContents(string _clipboard)
        {
            string clipboardCurrent = _clipboard;

            clipboardCurrent = Regex.Replace(clipboardCurrent, @"\s", "");

            //  Save data to previous if first time using this.
            if (clipboardPrevious == null)
            {
                clipboardPrevious = clipboardCurrent;
            }

            //  If the clipboard has changed.
            if (clipboardPrevious != clipboardCurrent)
            {
                hostnameTextBox.Text = clipboardCurrent;
                clipboardPrevious = clipboardCurrent;
                clearFormSysInfo();
            }
            else
            {
                hostnameTextBox.Text = clipboardCurrent;
            }
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            //  When form brought back into view/focused in Windows.
            hostnameTextBox.Focus();
            getClipboardContents();

            int maxClipBoardLength = Properties.Settings.Default.options_MaxHostnameLength;

            if (checkHostnameMatch(clipboardCurrent, maxClipBoardLength))
            {
                pasteClipboardContents(clipboardCurrent);
            }
       }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //  Attach tooltip to hostname field.
            System.Windows.Forms.ToolTip hostnameToolTip = new System.Windows.Forms.ToolTip();
            hostnameToolTip.SetToolTip(this.targetHostnameLabel, "Click to copy");

            //  Additional setup for AutoCompleteCollection.
            hostnameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            hostnameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            hostnameTextBox.AutoCompleteCustomSource = autoComplete;

            targetHostnameLabel.Text = "";
            targetLoggedOnUserLabel.Text = "";

            targetManufacturerLabel.Text = "";
            targetModelLabel.Text = "";

            targetCPUNameLabel.Text = "";
            targetRAMLabel.Text = "";

            targetSystemUptimeLabel.Text = "";

            targetStatusLabel.Text = "Press 'Enter' to connect.";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Patch Notes.
            //  TODO: Better patch notes idea?
            MessageBox.Show(

                "v1.0" + Environment.NewLine +
                " -Final tweaks for release of v1.0." + Environment.NewLine +

                Environment.NewLine +

                "v0.8.3" + Environment.NewLine +
                " -Feature: Redesigned home screen." + Environment.NewLine +
                " -Feature: You can change the default \"enter key\" action in Options -> Config." + Environment.NewLine +
                " -Feature: Maximum clipboard length option in Options -> Config." + Environment.NewLine +
                " -Fix: Lots of code cleanup and rearrangement." + Environment.NewLine +

                Environment.NewLine +

                "v0.8" + Environment.NewLine +
                " -Feature: Added more buttons, right click to configure." + Environment.NewLine +
                " -Feature: Manage remote computer button." + Environment.NewLine +
                " -Feature: Wipe your clipboard clean with one button (the red X)." + Environment.NewLine +
                " -Fix: The clipboard no longer pastes strings longer than 20 characters." + Environment.NewLine +

                Environment.NewLine +

                "v0.7" + Environment.NewLine +
                " -Feature: Clipboard Setup, configure what hostnames/IPs should be detected." + Environment.NewLine +
                " -Feature: Tools Menu, commands to run on the target machine." + Environment.NewLine +
                " -Feature: Copy the hostname by clicking it under the 'Information' panel." + Environment.NewLine +
                " -Fix: The 'information' panel now clears when populating the target machine field." + Environment.NewLine +

                Environment.NewLine +

                "v0.6.1" + Environment.NewLine +
                " -Clipboard integration now ignores spaces." + Environment.NewLine +

                Environment.NewLine +

                "v0.6" + Environment.NewLine +
                " -Separated WMI calls, if no user is logged on it would fail in previous versions." + Environment.NewLine +
                " -Added 'Uptime' information of target machine." + Environment.NewLine +
                " -Formating for RAM." + Environment.NewLine +
                " -General code cleanup." + Environment.NewLine +

                Environment.NewLine +

                "v0.5" + Environment.NewLine +
                " -The application is now fully threaded and provides feedback while functions run."

            , "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eventvwrButton_Click(object sender, EventArgs e)
        {
            _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
               {
                   actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));

                   ProcessStartInfo eventVwr = new ProcessStartInfo("eventvwr.exe");
                   eventVwr.Arguments = " " + hostnameTextBox.Text;

                   Process.Start(eventVwr);
               }));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Close the current form and exit.
            this.Close();
        }

        private void clipboardIntegrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clipboardIntegrationToolStripMenuItem.Checked == true) 
                { clipboardIntegrationToolStripMenuItem.Checked = false;}
            else 
                { clipboardIntegrationToolStripMenuItem.Checked = true; }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rebootTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hostnameTextBox.Text != "")
            {
                _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                    ProcessStartInfo rebootTarget = new ProcessStartInfo("shutdown.exe");
                    rebootTarget.Arguments = @" /m \\" + hostnameTextBox.Text + @" /r /t 0";

                    DialogResult result = MessageBox.Show("Are you sure? This will force reboot " + hostnameTextBox.Text + ".", "Reboot Target Machine", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Process.Start(rebootTarget);
                    }
                }));
            }
            else
            {
                MessageBox.Show("Invalid target", "Error", MessageBoxButtons.OK);
            }
        }

        private void listRemoteProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Get running processes on target machine.
            Process[] processes = Process.GetProcesses(hostnameTextBox.Text);

            //  Send process information to other form and show.
            Form remoteProcessesForm = new processList(processes);
            remoteProcessesForm.Show();
        }

        private void targetHostnameLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(targetHostnameLabel.Text);
            hostnameTextBox.Text = targetHostnameLabel.Text;
        }

        private void pcManagementButton_Click(object sender, EventArgs e)
        {
            _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
            {
                actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));

                ProcessStartInfo pcManagement = new ProcessStartInfo("compmgmt.msc");
                pcManagement.Arguments = @" /computer:\\" + hostnameTextBox.Text;

                Process.Start(pcManagement);
            }));
        }

        private void customShortcutButton1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                    //  Basic error handling.
                    try
                    {
                        Process.Start(@Properties.Settings.Default._customButton1_path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to connect to: " + @Properties.Settings.Default._customButton1_path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
            else if (e.Button == MouseButtons.Right)
            {
                configureCustomButtons configureCustomButtons = new configureCustomButtons("button1");
                this.Hide();
                configureCustomButtons.Show();
            }
        }

        private void customShortcutButton2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                    //  Basic error handling.
                    try
                    {
                        Process.Start(@Properties.Settings.Default._customButton2_path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to connect to: " + @Properties.Settings.Default._customButton2_path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
            else if (e.Button == MouseButtons.Right)
            {
                configureCustomButtons configureCustomButtons = new configureCustomButtons("button2");
                this.Hide();
                configureCustomButtons.Show();
            }
        }

        private void customShortcutButton3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                    //  Basic error handling.
                    try
                    {
                        Process.Start(@Properties.Settings.Default._customButton3_path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to connect to: " + @Properties.Settings.Default._customButton3_path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
            else if (e.Button == MouseButtons.Right)
            {
                configureCustomButtons configureCustomButtons = new configureCustomButtons("button3");
                this.Hide();
                configureCustomButtons.Show();
            }
        }

        private void customShortcutButton4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                    //  Basic error handling.
                    try
                    {
                        Process.Start(@Properties.Settings.Default._customButton4_path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to connect to: " + @Properties.Settings.Default._customButton4_path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
            else if (e.Button == MouseButtons.Right)
            {
                configureCustomButtons configureCustomButtons = new configureCustomButtons("button4");
                this.Hide();
                configureCustomButtons.Show();
            }
        }

        private void customShortcutButton5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                    //  Basic error handling.
                    try
                    {
                        Process.Start(@Properties.Settings.Default._customButton5_path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to connect to: " + @Properties.Settings.Default._customButton5_path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
            else if (e.Button == MouseButtons.Right)
            {
                configureCustomButtons configureCustomButtons = new configureCustomButtons("button5");
                this.Hide();
                configureCustomButtons.Show();
            }
        }

        private void cutomShortcutButton6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _BackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
                {
                    actionProgressBar.BeginInvoke(new MethodInvoker(() => actionProgressBar.Visible = true));
                    //  Basic error handling.
                    try
                    {
                        Process.Start(@Properties.Settings.Default._customButton6_path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to connect to: " + @Properties.Settings.Default._customButton6_path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
            else if (e.Button == MouseButtons.Right)
            {
                configureCustomButtons configureCustomButtons = new configureCustomButtons("button6");
                this.Hide();
                configureCustomButtons.Show();
            }
        }

        private void clearClipBoardButton_Click(object sender, EventArgs e)
        {
            hostnameTextBox.Text = "";
            Clipboard.Clear();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionsPage optionsPage = new optionsPage();
            this.Hide();
            optionsPage.Show();
        }

        private void wmiConnectButton_Click(object sender, EventArgs e)
        {
            runWmiQueries();
        }
    }
}
