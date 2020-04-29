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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private List<string> contentText = new List<string>();
        private Check check = new Check();

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            contentText.Add(accounTextBox.Text);
            contentText.Add(passwordTextBox.Text);
            contentText.Add(occupationComboBox.Text);
            contentText.Add(departmentComboBox.Text);
            contentText.Add(firstNameTextBox.Text);
            contentText.Add(lastNameTextBox.Text);
            contentText.Add(sexualComboBox.Text);
            contentText.Add(picPathTextBox.Text);
            contentText.Add(emailTextBox.Text);
            contentText.Add(confirmPwsTextBox.Text);

            List<string> occupation = new List<string>() { "外科醫生", "內科醫生", "藥師", "營養師" };

            if (occupation.Contains(occupationComboBox.Text))
            {
                contentText.Add(occupationComboBox.Text);
            }

            if (check.UserSignUpCheck(contentText))
            {
                string c_StrConnect = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = HospitalDB; Integrated Security = true";
                string c_StrCommand = "AccountExistCheck";
                Check check = new Check();
                if (check.AccountExistCheck(c_StrConnect, c_StrCommand, accounTextBox.Text) == 0)
                {
                    if (passwordTextBox.Text == confirmPwsTextBox.Text)
                    {
                        try
                        {
                            string strConnect = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = HospitalDB; Integrated Security = true";
                            string strCommand = "SignInProcedure";
                            Connections connections = new Connections();
                            connections.SignUp(strConnect,
                                               strCommand,
                                               accounTextBox.Text,
                                               passwordTextBox.Text,
                                               firstNameTextBox.Text,
                                               lastNameTextBox.Text,
                                               birthdayDTP.Value.ToShortDateString(),
                                               sexualComboBox.Text,
                                               emailTextBox.Text,
                                               occupationComboBox.Text,
                                               departmentComboBox.Text,
                                               picPathTextBox.Text,
                                               physicianIDTextBox.Text);
                            MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            this.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("請確認密碼是否相符", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("帳號已存在。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請確實填寫各欄位!");
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image(*.JPG; *.JPEG; *.PNG)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picPathTextBox.Text = pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void occupationComboBox_TextChanged(object sender, EventArgs e)
        {
            if (occupationComboBox.Text == "外科醫生" || occupationComboBox.Text == "內科醫生" || occupationComboBox.Text == "藥師")
            {
                physicianIDLabel.Visible = true;
                physicianIDTextBox.Visible = true;
            }
            else
            {
                physicianIDLabel.Visible = false;
                physicianIDTextBox.Visible = false;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Check.HasChinese(passwordTextBox.Text))
            {
                MessageBox.Show("不可使用中文", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel3.Visible = true;
                passwordTextBox.Text = "";
            }
            else
            {
                switch (Check.PasswordStrength(passwordTextBox.Text))
                {
                    case Check.Strength.Invalid:
                        pwsStrongLabel.Text = "Invaild";
                        medium.BackColor = weak.BackColor = strong.BackColor = Color.Gray;
                        break;

                    case Check.Strength.Weak:
                        pwsStrongLabel.Text = "Weak";
                        weak.BackColor = Color.Red;
                        medium.BackColor = strong.BackColor = Color.Gray;
                        break;

                    case Check.Strength.Normal:
                        pwsStrongLabel.Text = "Medium";
                        medium.BackColor = weak.BackColor = Color.Orange;
                        strong.BackColor = Color.Gray;
                        break;

                    case Check.Strength.Strong:
                        pwsStrongLabel.Text = "Strong";
                        medium.BackColor = weak.BackColor = strong.BackColor = Color.Green;
                        break;
                }
                panel3.Visible = false;
            }
        }

        private void confirmPwsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == confirmPwsTextBox.Text)
            {
                invalidPasswordLabel.Visible = false;
            }
            else
            {
                invalidPasswordLabel.Visible = true;
            }
        }

        private void accounTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Check.HasChinese(accounTextBox.Text))
            {
                MessageBox.Show("不可使用中文", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel1.Visible = true;
                accounTextBox.Text = "";
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Check.HasChinese(emailTextBox.Text))
            {
                MessageBox.Show("不可使用中文", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                invalidEmailLabel.Visible = true;
                panel5.Visible = true;
                emailTextBox.Text = "";
            }

            if (!Check.IsValidEMailAddress(emailTextBox.Text))
            {
                invalidEmailLabel.Visible = true;
                panel5.Visible = true;
            }
            else
            {
                invalidEmailLabel.Visible = false;
                panel5.Visible = false;
            }
        }

        private void physicianIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Check.HasChinese(passwordTextBox.Text))
            {
                MessageBox.Show("不可使用中文", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel4.Visible = true;
                passwordTextBox.Text = "";
            }
            else
            {
                panel4.Visible = false;
            }
        }
    }
}