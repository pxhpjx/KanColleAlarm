using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KanColleAlarm
{
    public partial class Alarm : Form
    {
        public List<Expedition> Expeditions = InitExpeditions();
        System.Timers.Timer UpdateTimer = null;
        object obj = new object();
        private Icon IcoNormal;
        private Icon IcoRed;

        public Alarm()
        {
            InitializeComponent();
            this.SizeChanged += Alarm_SizeChanged;
            cb1.DataSource = Expeditions.ConvertAll<int>(item => item.ID);
            cb2.DataSource = Expeditions.ConvertAll<int>(item => item.ID);
            cb3.DataSource = Expeditions.ConvertAll<int>(item => item.ID);
            UpdateTimer = new System.Timers.Timer(1000);
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.Start();
            IcoNormal = this.Icon;
            Image imgRed = (Image)this.Icon.ToBitmap();
            Graphics g = Graphics.FromImage(imgRed);
            Point[] ps = { new Point(0, 0), new Point(0, IcoNormal.Height), new Point(IcoNormal.Width, IcoNormal.Height), new Point(IcoNormal.Width, 0), new Point(0, 0) };
            g.DrawLines(new Pen(Color.Red, 5), ps);
            IcoRed = Icon.FromHandle(((Bitmap)imgRed).GetHicon());
            notifyIcon1.BalloonTipClicked += new EventHandler(notifyIcon1_BalloonTipClicked);
        }

        void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (notifyIcon1.Icon == IcoRed)
                notifyIcon1.Icon = IcoNormal;
            if (!this.Visible)
            {
                this.Visible = !this.Visible;
                this.WindowState = FormWindowState.Normal;
            }
        }

        void Alarm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Visible = false;
        }

        void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            lock (obj)
            {
                bool b1 = false, b2 = false, b3 = false;
                b1 = CheckWait(lblWait1);
                b2 = CheckWait(lblWait2);
                b3 = CheckWait(lblWait3);
                string str = "";
                if (b1)
                    str += "第二舰队远程结束\r\n";
                if (b2)
                    str += "第三舰队远程结束\r\n";
                if (b3)
                    str += "第四舰队远程结束";
                if (!string.IsNullOrWhiteSpace(str))
                {
                    notifyIcon1.Icon = IcoRed;
                    notifyIcon1.BalloonTipText = str;
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }
        }

        public bool CheckWait(Label lbl)
        {
            TimeSpan span = new TimeSpan();
            span = FormatTools.ParseTimeSpan(lbl.Text);
            if (span.TotalSeconds >= 1)
            {
                span = span.Add(new TimeSpan(0, 0, -1));
                BeginInvoke(new Action(() => lbl.Text = span.ToString()));
                if (span.TotalSeconds == 0)
                    return true;
            }
            return false;
        }

        public static List<Expedition> InitExpeditions()
        {
            List<Expedition> result = LogRecord.ReadSerXmlLog<List<Expedition>>(System.Windows.Forms.Application.StartupPath + "\\Expeditions.xml");
            return result;
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Expedition result = Expeditions.FirstOrDefault(item => item.ID.ToString() == cb1.SelectedValue.ToString());
            if (result != null)
            {
                lblName1.Text = result.Name;
                txtTimeCost1.Text = result.CostValue;
            }
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Expedition result = Expeditions.FirstOrDefault(item => item.ID.ToString() == cb2.SelectedValue.ToString());
            if (result != null)
            {
                lblName2.Text = result.Name;
                txtTimeCost2.Text = result.CostValue;
            }
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Expedition result = Expeditions.FirstOrDefault(item => item.ID.ToString() == cb3.SelectedValue.ToString());
            if (result != null)
            {
                lblName3.Text = result.Name;
                txtTimeCost3.Text = result.CostValue;
            }
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            lblWait1.Text = txtTimeCost1.Text;
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            lblWait2.Text = txtTimeCost2.Text;
        }

        private void btnGo3_Click(object sender, EventArgs e)
        {
            lblWait3.Text = txtTimeCost3.Text;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
            if (this.Visible)
                this.WindowState = FormWindowState.Normal;
            if (notifyIcon1.Icon == IcoRed)
                notifyIcon1.Icon = IcoNormal;
        }
    }
}
