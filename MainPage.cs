using ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManageSystem
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public static int PostID = 0;

        private void MainPage_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.who.int/news-room");
            timer.Enabled = true;

            userNameLabel.Text = LoginForm.UserName;

            List<string> occupation = new List<string>() { "外科醫生", "內科醫生" };
            List<string> occupation1 = new List<string>() { "藥師", "營養師" };

            if (occupation.Contains(LoginForm.Occupication))
            {
                medicalRecordBtn.Visible = medicalRecordBtn.Enabled = true;
            }
            else if (occupation1.Contains(LoginForm.Occupication))
            {
                pillsBtn.Visible = pillsBtn.Enabled = true;
            }
            else if (LoginForm.Occupication == "財務人員")
            {
                moneyBtn.Enabled = moneyBtn.Visible = true;
            }
            ReLoad();
        }

        #region 網頁

        private void whoBtn_Click(object sender, EventArgs e)
        {
            this.webBrowser.Navigate("https://www.who.int/news-room");
        }

        private void usCDCBtn_Click(object sender, EventArgs e)
        {
            this.webBrowser.Navigate("https://www.cdc.gov/");
        }

        private void taiwanCDCBtn_Click(object sender, EventArgs e)
        {
            this.webBrowser.Navigate("https://www.cdc.gov.tw/");
        }

        #endregion 網頁

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "現在時刻：" + DateTime.Now.ToString();
        }

        private void medicalRecordBtn_Click(object sender, EventArgs e)
        {
            MedicalRecordForm medicalRecordForm = new MedicalRecordForm();

            medicalRecordForm.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ver. 1.a\nDesigner : Johnny Wang\nWeb : www.hospital.org.com");
        }

        private void memberCentreBtn_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void patientDetailBtn_Click(object sender, EventArgs e)
        {
            PatientDataForm patientDataForm = new PatientDataForm();
            patientDataForm.ShowDialog();
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void ReLoad()
        {
            this.flowLayoutPanel.Controls.Clear();
            HospitalDBEntities dbContext = new HospitalDBEntities();
            var q = dbContext.Messageboards.OrderByDescending(n => n.Date).Select(n => n).ToList();

            foreach (var n in q)
            {
                MessageControl messageControl = new MessageControl();
                if (n.Name != LoginForm.UserName)
                {
                    messageControl.button1.Enabled = false;
                    messageControl.button1.Visible = false;
                }
                messageControl.label1.Text = n.Id.ToString();
                messageControl.linkLabel.Text = $"{n.Name}說：{n.Title}";
                flowLayoutPanel.Controls.Add(messageControl);
                messageControl.Width = this.flowLayoutPanel.Width - 10;
                richTextBox.Text = n.Content;
                label2.Text = $"【{n.Name.ToString()}】留言：";

                messageControl.linkLabel.Click += delegate (object sender1, EventArgs e1)
                {
                    richTextBox.Text = n.Content;
                    label2.Text = $"【{n.Name.ToString()}】留言：";
                };

                messageControl.button1.Click += delegate (object sender1, EventArgs e1)
                {
                    MessageEdit messageEdit = new MessageEdit();
                    PostID = int.Parse(messageControl.label1.Text);
                    messageEdit.ShowDialog();
                };
            }
        }

        private void pillsBtn_Click(object sender, EventArgs e)
        {
            PillsForm pillsForm = new PillsForm();

            pillsForm.ShowDialog();
        }

        private void moneyBtn_Click(object sender, EventArgs e)
        {
            FundationForm fundationForm = new FundationForm();
            fundationForm.ShowDialog();
        }
    }
}