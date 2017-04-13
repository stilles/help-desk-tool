using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Desk_Tool
{
    public partial class processList : Form
    {

        Process[] remoteProcesses;

        public processList(Process[] _remoteProcesses)
        {
            InitializeComponent();
            remoteProcesses = _remoteProcesses;
        }

        private void processList_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[0].HeaderText = "PID";
            dataGridView1.Columns[1].HeaderText = "Name";


            foreach (Process process in remoteProcesses)
            {
                dataGridView1.Rows.Add(new string[] { process.Id.ToString(), process.ProcessName } );
            }
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }
    }
}
