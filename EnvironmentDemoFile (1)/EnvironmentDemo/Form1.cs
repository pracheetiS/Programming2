using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvironmentDemo
{
    public partial class FrmEnvironment : Form
    {
        public FrmEnvironment()
        {
            InitializeComponent();
        }
        string[] drives;
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            OperatingSystem os = Environment.OSVersion;
            PlatformID osId = os.Platform;
            drives = Environment.GetLogicalDrives();
            string drive = "";
            foreach (string driv in drives)
            {
               
                drive += driv + " ";
            }
            LB.Items.Add("Operating Sys   " + os);
            LB.Items.Add("Operating Sys ID  " + osId);
            LB.Items.Add("CLR Version    " + Environment.Version);
            LB.Items.Add("Machine name    " + Environment.MachineName);
            LB.Items.Add("");
            LB.Items.Add("User ID + \t\t" + Environment.UserName);
            LB.Items.Add("Current Directory\t" + Environment.CurrentDirectory);
            LB.Items.Add("Drives Present\t" + drive);



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void abootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Demonstration Program for reading some of the available " + "\n\r Fall 2019 for NC CP2, T35");
        }
    }
}
