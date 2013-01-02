using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace NetLog
{
    public partial class frmLog : Form
    {
        private ScanVerbinding verbinding;
        private string LastState = ":";

        FileSystemWatcher watcher = new FileSystemWatcher();

        public frmLog()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            cmdStart.Enabled = false;
            verbinding = new ScanVerbinding(txtAdress.Text);
            Thread tr = new Thread(verbinding.run);
            tr.Start();

            watcher.Path = Application.StartupPath;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "uptime.csv";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;

            OnChanged(null, null);
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            String[] lines = File.ReadAllLines("uptime.csv");
            lvLog.Items.Clear();

            for (int i = lines.Length-1; i >= 0; i--)
            {
                lvLog.Items.Add(newLogLine(lines[i]));
            }

            string t = lines.Last().Split(',')[1];
            if (t != LastState)
            {
                if (t == "UP")
                {
                    sysIcon.Icon = getIcon(imgStatus.Images["UP"]);
                    sysIcon.ShowBalloonTip(1000, sysIcon.Text, "We zijn weer UP", ToolTipIcon.Info);
                }
                else if (t == "DOWN")
                {
                    sysIcon.Icon = getIcon(imgStatus.Images["DOWN"]);
                    sysIcon.ShowBalloonTip(1000, sysIcon.Text, "We zijn weer DOWN", ToolTipIcon.Error);
                }
                else
                {
                    sysIcon.Icon = getIcon(imgStatus.Images["ONBEKENT"]);
                }
            }
            LastState = t;
        }

        private System.Drawing.Icon getIcon(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            bitmap.SetResolution(72, 72);
            return System.Drawing.Icon.FromHandle(bitmap.GetHicon());
        }

        private ListViewItem newLogLine(string line)
        {
            String[] data = line.Split(',');

            /*double time = double.Parse(data[0]);

            DateTime date = DateTime.FromOADate(time);*/

            ListViewItem t = new ListViewItem(new String[]{data[0], data[1]});

            if (data[1] == "UP")
            {
                t.BackColor = Color.LightGreen;
            }
            else if (data[1] == "DOWN")
            {
                t.BackColor = Color.Pink;
            }
            else
            {
                t.BackColor = Color.LightYellow;
            }

            return t;
        }

        private void frmLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ScanVerbinding.Stop = true;
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            sysIcon.Text = this.Text;
            sysIcon.Icon = this.Icon;
            sysIcon.Visible = true;
        }

        private void frmLog_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void frmLog_StyleChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }

        private void sysIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized || this.Visible == false)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }

        }
    }
}
