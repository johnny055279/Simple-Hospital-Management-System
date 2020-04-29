using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManageSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private HospitalDBEntities dbContext = new HospitalDBEntities();

        private string text = "Today's News : Canada’s doctors launch new campaign to bring health information about COVID-19 to Canadians.                    ";

        public string Username
        {
            get
            {
                return accountTextBox.Text;
            }
            set
            {
                accountTextBox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordTextBox.Text;
            }
            set
            {
                passwordTextBox.Text = value;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string temp = text.Substring(0, 1);
            text = text.Substring(1, text.Length - 1) + temp;
            label4.Text = text;
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to end the system?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();

            signUpForm.Show();
        }

        public static string UserName = "";
        public static int UserId = 1;
        public static string PhysicianID = "";
        public static string Occupication = "";

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string strConnect = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = HospitalDB; Integrated Security = true";
            string strCommand = "LoginProcedure";
            Connections connections = new Connections();

            if (connections.LogIn(strConnect, strCommand, Username, Password) == 0)
            {
                infoLabel.Visible = true;
            }
            else
            {
                MainPage mainPage = new MainPage();

                UserName = dbContext.Employees.AsEnumerable().Where(n => n.Account == Username).Select(n => $"{ n.FirstName} {n.LastName}").First(); ;
                UserId = dbContext.Employees.Where(n => n.Account == Username).Select(n => n.EmployeeId).First();
                Occupication = dbContext.Employees.Where(n => n.Account == Username).Select(n => n.Occupation).First();
                PhysicianID = dbContext.Employees.Where(n => n.Account == Username).Select(n => n.PhysicianID).First();
                MessageBox.Show($"歡迎回來...{UserName}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accountTextBox.Text = "";
                passwordTextBox.Text = "";

                mainPage.FormClosed += MainPage_FormClosed;
                infoLabel.Visible = false;
                this.Hide();
                mainPage.ShowDialog();
            }
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void forgetPWSLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForgetForm passwordForgetForm = new PasswordForgetForm();

            passwordForgetForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountTextBox.Text = "EastEvil";
            passwordTextBox.Text = "eastevil";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accountTextBox.Text = "Pepper";
            passwordTextBox.Text = "pepper";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accountTextBox.Text = "Lee";
            passwordTextBox.Text = "lee";
        }
    }
}