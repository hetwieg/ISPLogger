using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NetStatus
{
    public partial class frmStatus : Form
    {
        private int UpCount = 0;
        private int DownCount = 0;

        private long MaxDown = 0;
        private long MaxUp = 0;

        private long TimeDown = 0;
        private long TimeUp = 0;

        private String lastState = "";
        private DateTime lastTime = new DateTime(0);

        FileSystemWatcher watcher = new FileSystemWatcher();

        public frmStatus()
        {
            InitializeComponent();
            watcher.Path = Application.StartupPath;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "uptime.csv";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;

            OnChanged(null, null);
        }

        private string getTime(long value)
        {
            DateTime d = new DateTime(Abs(value));

            return String.Format("{0}:{1:00}:{2:00}", d.Hour + ((d.DayOfYear - 1) * 24), d.Minute, d.Second);
        }

        private long Abs(long value)
        {
            if (value < 0) return value * -1;
            return value;
        }

        private ListViewItem newLogLine(string line)
        {
            String[] data = line.Split(',');

            DateTime date = getDate(data[0]);
            if (lastTime.Ticks == 0) lastTime = date;

            ListViewItem t = new ListViewItem(new String[] { data[0], data[1] });

            if (data[1] == "UP")
            {
                t.BackColor = Color.LightGreen;
                t.ImageKey = "UP";
                UpCount++;

                if ((lastState == "DOWN" || lastState == "") && (Abs(date.Ticks - lastTime.Ticks) > MaxDown))
                    MaxDown = Abs(date.Ticks - lastTime.Ticks);

                lastState = "UP";
                TimeUp = Abs(TimeUp + date.Ticks - lastTime.Ticks);
                lastTime = date;
            }
            else if (data[1] == "DOWN")
            {
                t.BackColor = Color.Pink;
                t.ImageKey = "DOWN";
                DownCount++;

                if ((lastState == "UP" || lastState == "") && (Abs(date.Ticks - lastTime.Ticks) > MaxUp))
                    MaxUp = Abs(date.Ticks - lastTime.Ticks);

                lastState = "DOWN";
                TimeDown = Abs(TimeDown + date.Ticks - lastTime.Ticks);
                lastTime = date;
            }
            else
            {
                t.BackColor = Color.LightYellow;
                t.ImageKey = "ONBEKENT";
            }
            return t;
        }

        private DateTime getDate(String data)
        {
            String[] day = data.Split(' ')[0].Split('/');
            String[] time = data.Split(' ')[1].Split(':');

            return new DateTime(int.Parse(day[2]), int.Parse(day[1]), int.Parse(day[0]),
                int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]));
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {

        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            UpCount = 0;
            DownCount = 0;
            MaxDown = 0;
            MaxUp = 0;
            TimeDown = 0;
            TimeUp = 0;

            lastState = "";
            lastTime = new DateTime(0);

            String[] lines = File.ReadAllLines("uptime.csv");
            lvLog.Items.Clear();

            for (int i = lines.Length - 1; i >= 0; i--)
            {
                lvLog.Items.Add(newLogLine(lines[i]));
            }

            lvGegevensUpDown.Items.Clear();
            lvGegevensUpDown.Items.Add(new ListViewItem(new String[] { "Aantal", UpCount.ToString(), DownCount.ToString() }));
            lvGegevensUpDown.Items.Add(new ListViewItem(new String[] { "Max", getTime(MaxUp), getTime(MaxDown) }));
            lvGegevensUpDown.Items.Add(new ListViewItem(new String[] { "Total", getTime(TimeUp), getTime(TimeDown) }));}
    }
}
