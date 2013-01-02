using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

namespace NetLog
{
    public class ScanVerbinding
    {
        private Ping pingSender = new Ping();
        private string address = "127.0.0.1";
        private IPStatus lastStat = IPStatus.Unknown;
        public static bool Stop = false;

        public ScanVerbinding(string adres)
        {
            address = adres;
        }

        public void run()
        {
            String file = "uptime.csv";

            File.AppendAllText(file, String.Format("{0},START,\n", getTime()));

            while (!Stop)
            {
                PingReply reply = pingSender.Send(address);
                if (reply.Status != lastStat)
                {
                    String log = "";

                    if (reply.Status == IPStatus.Success)
                    {
                        log = String.Format("{0},UP,\n", getTime());
                    }
                    else if (reply.Status == IPStatus.TimedOut)
                    {
                        log = String.Format("{0},DOWN,\n", getTime());
                    }
                    else
                    {
                        log = String.Format("{0},ONBEKENT,\"{1}\"\n", getTime(), reply.Status);
                    }

                    lastStat = reply.Status;
                    File.AppendAllText(file, log);
                }

                Thread.Sleep(1000);
            }

            File.AppendAllText(file, String.Format("{0},STOP,\n", getTime()));
        }

        private string getTime()
        {
            return DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }
    }
}

// 62.45.30.177