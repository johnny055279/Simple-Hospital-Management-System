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
    public partial class PasswordForgetForm : Form
    {
        public PasswordForgetForm()
        {
            InitializeComponent();
        }

        private HospitalDBEntities dbContext = new HospitalDBEntities();

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                var q = dbContext.Employees.Where(n => n.Account == accountTextBox.Text).Select(n => n).First();

                if (q != null)
                {
                    MailSending mailSending = new MailSending();
                    mailSending.PasswordSendingToMail(q.Email, passWordGenarator());

                    MessageBox.Show("信件已寄至您的Email!");
                }
            }
            catch
            {
                MessageBox.Show("帳號輸入有問題喔!");
            }
        }

        private string passWordGenarator()
        {
            string allowChar = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%&";
            Random random = new Random();
            int passwordLengrh = 10;

            char[] c = new char[passwordLengrh];

            for (int i = 0; i < passwordLengrh; i++)
            {
                c[i] = allowChar[random.Next(0, allowChar.Length)];
            }

            string pws = new String(c);
            return pws;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}